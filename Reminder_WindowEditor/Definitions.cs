using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder_WindowEditor
{
    class Definitions
    {
        public enum WindowStyles
        {
            WS_BORDER = 0x00800000,
            WS_CHILD = 0x40000000,
            WS_DISABLED = 0x08000000,
            WS_THICKFRAME = 0x00040000,
            WS_OVERLAPPED = 0x00000000,
            WS_SYSMENU = 0x00080000,
            WS_MINIMIZEBOX = 0x00020000,
            WS_MAXIMIZEBOX = 0x00010000,
            WS_CAPTION = 0x00C00000,
            WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,
        }

        public enum GetWindowLong
        {
            GWL_STYLE = -16,
            GWL_EXSTYLE = -20
        }

        public enum SetWindowPosition
        {
            SWP_FRAMECHANGED =  0x0020,
            SWP_NOMOVE =  0x0002,
            SWP_NOSIZE = 0x0001,
            SWP_NOZORDER = 0x0004,

        }

        public enum RedrawWindow
        {
            RDW_INVALIDATE = 0x0001,
            RDW_FRAME = 0x0400,
            RDW_UPDATENOW = 0x0100
        }
    }
}
