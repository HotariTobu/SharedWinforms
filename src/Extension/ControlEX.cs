using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharedWinforms.Extension
{
    public static class ControlEX
    {
        public static void AutoScroll(this Control control, int margin = 20)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Point point = control.PointToClient(Cursor.Position);

            if ((point.X + margin) > control.ClientSize.Width)
            {
                Win32EX.SendMessage(control.Handle, 0x0114, (IntPtr)1, (IntPtr)0);
            }
            else if (point.X < margin)
            {
                Win32EX.SendMessage(control.Handle, 0x0114, (IntPtr)0, (IntPtr)0);
            }

            if ((point.Y + margin) > control.ClientSize.Height)
            {
                Win32EX.SendMessage(control.Handle, 0x0115, (IntPtr)1, (IntPtr)0);
            }
            else if (point.Y < margin)
            {
                Win32EX.SendMessage(control.Handle, 0x0115, (IntPtr)0, (IntPtr)0);
            }
        }

        public static void SuspendDrawing(this Control control)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Win32EX.SendMessage(control.Handle, 0x000b, (IntPtr)0, (IntPtr)0);
        }

        public static void ResumeDrawing(this Control control, bool refresh = true)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Win32EX.SendMessage(control.Handle, 0x000b, (IntPtr)1, (IntPtr)0);
            if (refresh)
            {
                control.Refresh();
            }
        }

        public static void ScrollBy(this ScrollableControl control, Size difference)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            control.AutoScrollPosition = new Point(-(control.AutoScrollPosition.X + difference.Width), -(control.AutoScrollPosition.Y + difference.Height));
        }
    }
}
