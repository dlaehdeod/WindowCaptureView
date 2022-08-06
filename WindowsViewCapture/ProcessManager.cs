using System;
using System.Runtime.InteropServices;

namespace WindowsViewCapture
{
    public struct Rect
    {
        public int left, top, right, bottom;
    }

    public class ProcessManager
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32")]
        public static extern int GetWindowRect(IntPtr hwnd, out Rect lpRect);

        [DllImport("dwmapi.dll")]
        public static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out Rect pvAttribute, int cbAttribute);

        //https://docs.microsoft.com/en-us/windows/win32/api/dwmapi/ne-dwmapi-dwmwindowattribute
        private const int DWMWA_EXTENDED_FRAME_BOUNDS = 9;

        private IntPtr customHWnd;

        public void SetCustomHWnd (IntPtr hWnd)
        {
            customHWnd = hWnd;
        }

        public Rect GetCustomSizeRectInfo ()
        {
            Rect rcWindow, rcFrame;

            GetWindowRect(customHWnd, out rcWindow);

            DwmGetWindowAttribute(customHWnd, DWMWA_EXTENDED_FRAME_BOUNDS, out rcFrame, Marshal.SizeOf<Rect>());

            rcWindow.left = rcWindow.left + (rcFrame.left - rcWindow.left);
            rcWindow.right = rcWindow.right + (rcFrame.right - rcWindow.right);
            rcWindow.top = rcWindow.top + (rcFrame.top - rcWindow.top);
            rcWindow.bottom = rcWindow.bottom + (rcFrame.bottom - rcWindow.bottom);

            return rcWindow;
        }

        public Rect GetForegroundWindowRectInfo ()
        {
            Rect rcWindow, rcFrame;

            IntPtr hWnd = GetForegroundWindow();
            GetWindowRect(hWnd, out rcWindow);

            DwmGetWindowAttribute(hWnd, DWMWA_EXTENDED_FRAME_BOUNDS, out rcFrame, Marshal.SizeOf<Rect>());

            rcWindow.left = rcWindow.left + (rcFrame.left - rcWindow.left);
            rcWindow.right = rcWindow.right + (rcFrame.right - rcWindow.right);
            rcWindow.top = rcWindow.top + (rcFrame.top - rcWindow.top);
            rcWindow.bottom = rcWindow.bottom + (rcFrame.bottom - rcWindow.bottom);

            return rcWindow;
        }
    }
}
