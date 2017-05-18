using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reminder_WindowEditor
{
    class WindowsAPI
    {
        [DllImport("user32.dll", EntryPoint = "GetWindowLong", CharSet = CharSet.Auto)]
        private static extern IntPtr GetWindowLong32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr", CharSet = CharSet.Auto)]
        private static extern IntPtr GetWindowLong64(IntPtr hWnd, int nIndex);

        public static IntPtr GetWindowLong(IntPtr hWnd, int nIndex)
        {
            if (IntPtr.Size == 4)
            {
                return GetWindowLong32(hWnd, nIndex);
            }
            return GetWindowLong64(hWnd, nIndex);
        }

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLong")]
        private static extern IntPtr SetWindowLong32(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLong64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        public static IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            if (IntPtr.Size == 4)
            {
                return SetWindowLong32(hWnd, nIndex, dwNewLong);
            }
            return SetWindowLong64(hWnd, nIndex, dwNewLong);
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy,
        uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RedrawWindow(IntPtr hWind, int NOT_USED_SET_NULL, IntPtr hrgn, uint flags);


    }
}
