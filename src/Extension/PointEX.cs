using System;
using System.Drawing;

namespace SharedWinforms.Extension
{
    public static class PointEX
    {
        public static PointF ToPointF(this Point point)
        {
            return point;
        }
        public static Size ToSize(this Point point)
        {
            return new Size(point.X, point.Y);
        }
        public static SizeF ToSizeF(this Point point)
        {
            return new SizeF(point.X, point.Y);
        }

        public static Point ToPoint(this PointF point)
        {
            return new Point((int)point.X, (int)point.Y);
        }
        public static Size ToSize(this PointF point)
        {
            return new Size((int)point.X, (int)point.Y);
        }
        public static SizeF ToSizeF(this PointF point)
        {
            return new SizeF(point.X, point.Y);
        }

        public static Point Add(this Point point1, Point point2)
        {
            return new Point(point1.X + point2.X, point1.Y + point2.Y);
        }
        public static Point Sub(this Point point1, Point point2)
        {
            return new Point(point1.X - point2.X, point1.Y - point2.Y);
        }
        public static Point Mul(this Point point1, Point point2)
        {
            return new Point(point1.X * point2.X, point1.Y * point2.Y);
        }
        public static Point Div(this Point point1, Point point2)
        {
            return new Point(point1.X / point2.X, point1.Y / point2.Y);
        }

        public static PointF Add(this PointF point1, PointF point2)
        {
            return new PointF(point1.X + point2.X, point1.Y + point2.Y);
        }
        public static PointF Sub(this PointF point1, PointF point2)
        {
            return new PointF(point1.X - point2.X, point1.Y - point2.Y);
        }
        public static PointF Mul(this PointF point1, PointF point2)
        {
            return new PointF(point1.X * point2.X, point1.Y * point2.Y);
        }
        public static PointF Div(this PointF point1, PointF point2)
        {
            return new PointF(point1.X / point2.X, point1.Y / point2.Y);
        }

        public static Rectangle GetRectangle(this Point point1, Point point2)
        {
            return new Rectangle(
                Math.Min(point1.X, point2.X),
                Math.Min(point1.Y, point2.Y),
                Math.Abs(point1.X - point2.X),
                Math.Abs(point1.Y - point2.Y)
                );
        }
    }
}
