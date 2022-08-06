using System;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

//Hash
//https://docs.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/general/compute-hash-values

namespace WindowsViewCapture
{
    public partial class Form_Main : Form
    {
        public static Form_Main instance = null; 
        public static Form_CustomSize form_customSize = new Form_CustomSize();
        
        private static HookManager hookManager = new HookManager(); 
        private static Form_ScreenEffect form_screenEffect = new Form_ScreenEffect();

        public static string savePath = string.Empty;
        public static string fileName = "_Image";
        public static int screenShotNumber = 1;
        public static bool showSaveEffect = true;
        public static bool containTaskbar = false;
        public static bool frontNumber = true;
        public static bool customRange = false;

        private const string settingFile = "캡쳐옵션.txt";
        private Form_Option form_option;

        public static void ScreenShot(int width, int height, int x, int y)
        {
            FormWindowState windowState = instance.WindowState;
            instance.WindowState = FormWindowState.Minimized;

            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.CopyFromScreen(x, y, 0, 0, bitmap.Size);

            string totalPath;
            if (frontNumber)
            {
                totalPath = Path.Combine(savePath, string.Format("{0}{1}.png", screenShotNumber, fileName));
            }
            else
            {
                totalPath = Path.Combine(savePath, string.Format("{0}{1}.png", fileName, screenShotNumber));
            }

            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }

            bitmap.Save(totalPath, ImageFormat.Png);
            screenShotNumber++;

            form_screenEffect.Show();
            form_screenEffect.Initialize(width, height, x, y, showSaveEffect);

            instance.WindowState = windowState;
        }

        private static int GetFileFrontNumber (string name)
        {
            int index = name.IndexOf(fileName);

            if (index < 1)
            {
                return -1;
            }

            int number = 0;
            for (int i = 0; i < index; ++i)
            {
                number = number * 10 + name[i] - '0';
            }

            return number;
        }

        private static int GetFileRearNumber (string name)
        {
            int index = name.IndexOf(fileName);

            if (index != 0)
            {
                return -1;
            }

            int number = 0;
            for (int i = fileName.Length; name[i] != '.'; ++i)
            {
                number = number * 10 + name[i] - '0';
            }

            return number;
        }

        public static void CheckFileNumber ()
        {
            if (Directory.Exists(savePath))
            {
                string[] files = Directory.GetFiles(savePath, "*.png", SearchOption.TopDirectoryOnly);
                screenShotNumber = 1;

                if (frontNumber)
                {
                    foreach (string file in files)
                    {
                        screenShotNumber = Math.Max(screenShotNumber, GetFileFrontNumber(Path.GetFileName(file)) + 1);
                    }
                }
                else
                {
                    foreach (string file in files)
                    {
                        screenShotNumber = Math.Max(screenShotNumber, GetFileRearNumber(Path.GetFileName(file)) + 1);
                    }
                }
            }
            else
            {
                screenShotNumber = 1;
            }
        }

        public Form_Main()
        {
            instance = this;
            InitializeComponent();

            savePath = Environment.CurrentDirectory;
            if (File.Exists(settingFile))
            {
                string[] contents = File.ReadAllLines(settingFile);

                savePath = CheckStringValue(contents, 0, 1, savePath);
                fileName = CheckStringValue(contents, 2, 3, fileName);
                showSaveEffect = CheckOptionValue(contents, 4);
                containTaskbar = CheckOptionValue(contents, 5);
                frontNumber = CheckOptionValue(contents, 6);
            }

            CheckFileNumber();
        }

        private string CheckStringValue (string[] contents, int index, int hashIndex, string defaultValue)
        {
            if (contents.Length <= hashIndex || string.IsNullOrWhiteSpace(contents[index]) || string.IsNullOrWhiteSpace(contents[hashIndex]))
            {
                return defaultValue;
            }

            string targetHash = GetHashString(contents[index]);
            string preHash = contents[hashIndex];

            if (preHash == targetHash)
            {
                return contents[index];
            }
            else
            {
                return defaultValue;
            }
        }

        private string GetHashString(string target)
        {
            byte[] hashByte = Encoding.UTF8.GetBytes(target);
            hashByte = new MD5CryptoServiceProvider().ComputeHash(hashByte); //해시 암호 걸어보기~

            StringBuilder stringBuilder = new StringBuilder(hashByte.Length);
            for (int i = 0; i < hashByte.Length - 1; i++)
            {
                stringBuilder.Append(hashByte[i].ToString("X2")); //X2 type : hexadecimal (16진수)
            }

            return stringBuilder.ToString();
        }

        private bool CheckOptionValue (string[] contents, int index)
        {
            if (contents.Length < index || string.IsNullOrWhiteSpace(contents[index]))
            {
                return false;
            }

            return contents[index][0] == 'T';
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.Bounds.Width - this.Size.Width;
            int y = 0;

            this.Location = new Point(x, y);

            form_option = new Form_Option();

            hookManager.SetHook();
            hookManager.SetHWndCustomSize(form_customSize.Handle);
        }

        private void button_option_Click(object sender, EventArgs e)
        {
            form_option.Initialize();
            form_option.Show();
        }

        private void button_customSize_Click(object sender, EventArgs e)
        {
            customRange = true;
            form_customSize.Show();
        }

        private void button_minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            hookManager.UnHook();
            SaveOption();
        }

        private void SaveOption ()
        {
            string[] data = new string[7];
            data[0] = savePath;
            data[1] = GetHashString(savePath);
            data[2] = fileName;
            data[3] = GetHashString(fileName);
            data[4] = showSaveEffect.ToString();
            data[5] = containTaskbar.ToString();
            data[6] = frontNumber.ToString();

            File.WriteAllLines(Path.Combine(Environment.CurrentDirectory, settingFile), data);
        }
    }
}