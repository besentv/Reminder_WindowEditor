using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Reminder_WindowEditor.Definitions.SetWindowPosition;

namespace Reminder_WindowEditor
{
    class Program
    {
        [DllImport("USER32.DLL")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll")]
        static extern IntPtr GetMenu(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern int GetMenuItemCount(IntPtr hMenu);

        [DllImport("user32.dll")]
        static extern bool DrawMenuBar(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

        public static uint MF_BYPOSITION = 0x400;
        public static uint MF_REMOVE = 0x1000;

        public const long WS_EX_WINDOWEDGE = 0x00000100L;
        public const long WS_EX_CLIENTEDGE = 0x00000200L;
        public const long WS_EX_LAYERED = 0x00080000L;
        public const long WS_EX_STATICEDGE = 0x00020000L;
        public const long WS_EX_DLGMODALFRAME = 0x00000001L;
        public const long WS_EX_COMPOSITED = 0x02000000L;
        public const long WS_EX_TOOLWINDOW = 0x00000080L;
        public const long WS_EX_APPWINDOW = 0x00040000L;

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new MainUI());
        }

        public static void removeWindowBorder(Process proc)
        {
            long windowStyle = 0;
            IntPtr windowHandle = proc.MainWindowHandle;
            windowStyle = (long)WindowsAPI.GetWindowLong(windowHandle, (int)Definitions.GetWindowLong.GWL_STYLE);
            windowStyle &= ~((long)Definitions.WindowStyles.WS_OVERLAPPEDWINDOW);
            WindowsAPI.SetWindowLong(windowHandle, (int)Definitions.GetWindowLong.GWL_STYLE, (IntPtr)windowStyle);
            uint swpArg = (uint)(SWP_FRAMECHANGED | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER);

            if(true == WindowsAPI.SetWindowPos(windowHandle, (IntPtr)0, 0, 0, 0, 0, swpArg))
            {
                MessageBox.Show("OK");
            }
            //WindowsAPI.RedrawWindow(windowHandle, 0, IntPtr.Zero, (uint)(Definitions.RedrawWindow.RDW_FRAME | Definitions.RedrawWindow.RDW_INVALIDATE));
        }

        public static void changeWindowPos(int x, int y,Process proc)
        {
            IntPtr windowHandle = proc.MainWindowHandle;
            WindowsAPI.SetWindowPos(windowHandle, IntPtr.Zero, x, y,0, 0, (uint)(SWP_NOSIZE | SWP_NOZORDER));
        }
        public static void changeWindowSize(int width, int height, Process proc)
        {
            IntPtr windowHandle = proc.MainWindowHandle;
            WindowsAPI.SetWindowPos(windowHandle, IntPtr.Zero, 0, 0, width, height, (uint)(SWP_NOMOVE | SWP_NOZORDER));
        }
    }
}
