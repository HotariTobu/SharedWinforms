using System;
using System.Runtime.InteropServices;

namespace SharedWinforms.Extension
{
    public static class Win32EX
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, UInt32 wMsg, IntPtr wParam, IntPtr lParam);
    }
}
