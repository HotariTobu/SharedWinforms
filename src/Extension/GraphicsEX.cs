using System;
using System.Drawing;

namespace SharedWinforms.Extension
{
    public static class GraphicsEX
    {
        public static void DrawRectangle(this Graphics graphics, Pen pen, PointF point1, PointF point2)
        {
            if (graphics == null)
            {
                throw new ArgumentNullException("graphics");
            }

            graphics.DrawLine(pen, point1.X, point1.Y, point2.X, point1.Y);
            graphics.DrawLine(pen, point2.X, point1.Y, point2.X, point2.Y);
            graphics.DrawLine(pen, point1.X, point2.Y, point2.X, point2.Y);
            graphics.DrawLine(pen, point1.X, point1.Y, point1.X, point2.Y);
        }

        public static void FillEllipse(this Graphics graphics, Brush brush, int x, int y, Size size)
        {
            if (graphics == null)
            {
                throw new ArgumentNullException("graphics");
            }

            graphics.FillEllipse(brush, x, y, size.Width, size.Height);
        }

        public static void DrawEllipse(this Graphics graphics, Pen pen, int x, int y, Size size)
        {
            if (graphics == null)
            {
                throw new ArgumentNullException("graphics");
            }

            graphics.DrawEllipse(pen, x, y, size.Width, size.Height);
        }
    }
}
