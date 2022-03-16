using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsViewCapture
{
    public partial class Form_Option : Form
    {
        private const string cantUseFileName = "\\/:*?\"<>|";
        private string currentFileName;

        public Form_Option()
        {
            InitializeComponent();

            int x = Screen.PrimaryScreen.Bounds.Width - this.Size.Width;
            int y = 0;

            this.Location = new Point(x, y);
        }

        public void Initialize ()
        {
            textBox_savePath.Text = Form_Main.savePath;
            folderBrowserDialog1.SelectedPath = Form_Main.savePath;

            textBox_fileName.Text = Form_Main.fileName;
            currentFileName = Form_Main.fileName;

            checkBox_saveEffect.Checked = Form_Main.showSaveEffect;
            checkBox_taskbar.Checked = Form_Main.containTaskbar;

            if (Form_Main.frontNumber)
            {
                radioButton_front.Checked = true;
            }
            else
            {
                radioButton_back.Checked = true;
            }
        }

        private void button_setPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox_savePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form_Option_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Hide();
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                Save();
                e.Handled = true;
            }
        }

        private void Form_Option_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
        private void button_done_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Save ()
        {
            if (Form_Main.savePath != folderBrowserDialog1.SelectedPath ||
                Form_Main.frontNumber != radioButton_front.Checked)
            {
                Form_Main.savePath = folderBrowserDialog1.SelectedPath;
                Form_Main.CheckFileNumber();
            }
            
            Form_Main.fileName = textBox_fileName.Text;
            Form_Main.frontNumber = radioButton_front.Checked;
            Form_Main.showSaveEffect = checkBox_saveEffect.Checked;
            Form_Main.containTaskbar = checkBox_taskbar.Checked;
            Hide();
        }

        private void textBox_fileName_TextChanged(object sender, EventArgs e)
        {
            string name = textBox_fileName.Text;
            int length = name.Length;
            int subLength = cantUseFileName.Length;
            for (int i = 0; i < length; ++i)
            {
                for (int j = 0; j < subLength; ++j)
                {
                    if (name[i] == cantUseFileName[j])
                    {
                        textBox_fileName.Text = currentFileName;
                        MessageBox.Show(cantUseFileName + " 문자는 사용할 수 없습니다.");
                        return;
                    }
                }
            }

            currentFileName = textBox_fileName.Text;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("1{0}", currentFileName);
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("2{0}", currentFileName);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("...");
            stringBuilder.AppendFormat("10{0}", currentFileName);
            
            textBox_smartEx.Text = stringBuilder.ToString();

            stringBuilder.Clear(); 
            stringBuilder.AppendFormat("{0}1", currentFileName);
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("{0}2", currentFileName);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("...");
            stringBuilder.AppendFormat("{0}10", currentFileName);

            textBox_simpleEx.Text = stringBuilder.ToString();
        }
    }
}