using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

//Microsoft Hook Document
//https://docs.microsoft.com/en-us/windows/win32/winmsg/hooks

namespace WindowsViewCapture
{
    public class HookManager
    {
        private static ProcessManager processManager = new ProcessManager();

        [DllImport("user32.dll")] //C:\Windows\System32\user32.dll 참조
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private LowLevelKeyboardProc lowLevelKeyboardProc = HookProc;
        
        //WM_Keydown
        //https://wiki.winehq.org/List_Of_Windows_Messages
        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 256;
        const int WM_SYSKEYDOWN = 260;

        private static IntPtr hookId = IntPtr.Zero;

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hookId = SetWindowsHookEx(WH_KEYBOARD_LL, lowLevelKeyboardProc, hInstance, 0);
        }

        public void UnHook()
        {
            UnhookWindowsHookEx(hookId);
        }

        public static IntPtr HookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0)
            {
                if (wParam == (IntPtr)WM_SYSKEYDOWN) //ALT KeyDown
                {
                    Keys key = (Keys)Marshal.ReadInt32(lParam);

                    if (key == Keys.PrintScreen)
                    {
                        Rect rectInfo = processManager.GetForegroundWindowRectInfo();
                        Form_Main.ScreenShot(rectInfo.right - rectInfo.left, rectInfo.bottom - rectInfo.top, rectInfo.left, rectInfo.top);
                        return (IntPtr)1;
                    }
                }
                else if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    Keys key = (Keys)Marshal.ReadInt32(lParam);

                    switch (key)
                    {
                        case Keys.PrintScreen:

                            if (Form_Main.customRange)
                            {
                                int width = Form_Main.form_customSize.Width;
                                int height = Form_Main.form_customSize.Height;
                                int x = Form_Main.form_customSize.Location.X;
                                int y = Form_Main.form_customSize.Location.Y;
                                
                                Form_Main.form_customSize.Visible = false;
                                Form_Main.ScreenShot(width, height, x, y);
                                Form_Main.form_customSize.Visible = true;
                            }
                            else if (Form_Main.containTaskbar)
                            {
                                Form_Main.ScreenShot(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 0, 0);
                            }
                            else
                            {
                                Form_Main.ScreenShot(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height, 0, 0);
                            }

                            return (IntPtr)1;

                        case Keys.Pause:

                            Form_Main.form_customSize.ToggleView();
                            break;
                    }
                }
            }

            return CallNextHookEx(hookId, code, (int)wParam, lParam);
        }
    }
}
