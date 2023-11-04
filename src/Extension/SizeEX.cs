using System.Drawing;

namespace SharedWinforms.Extension
{
    public static class SizeEX
    {
        public static Point ToPoint(this Size size)
        {
            return new Point(size.Width, size.Height);
        }
        public static PointF ToPointF(this Size size)
        {
            return new PointF(size.Width, size.Height);
        }
        public static SizeF ToSize(this Size size)
        {
            return size;
        }

        public static Point ToPoint(this SizeF size)
        {
            return new Point((int)size.Width, (int)size.Height);
        }
        public static PointF ToPointF(this SizeF size)
        {
            return new PointF(size.Width, size.Height);
        }
        public static Size ToSize(this SizeF size)
        {
            return new Size((int)size.Width, (int)size.Height);
        }

        public static Size Add(this Size size1, Size size2)
        {
            return new Size(size1.Width + size2.Width, size1.Height + size2.Height);
        }
        public static Size Sub(this Size size1, Size size2)
        {
            return new Size(size1.Width - size2.Width, size1.Height - size2.Height);
        }
        public static Size Mul(this Size size1, Size size2)
        {
            return new Size(size1.Width * size2.Width, size1.Height * size2.Height);
        }
        public static Size Div(this Size size1, Size size2)
        {
            return new Size(size1.Width / size2.Width, size1.Height / size2.Height);
        }

        public static SizeF Add(this SizeF size1, SizeF size2)
        {
            return new SizeF(size1.Width + size2.Width, size1.Height + size2.Height);
        }
        public static SizeF Sub(this SizeF size1, SizeF size2)
        {
            return new SizeF(size1.Width - size2.Width, size1.Height - size2.Height);
        }
        public static SizeF Mul(this SizeF size1, SizeF size2)
        {
            return new SizeF(size1.Width * size2.Width, size1.Height * size2.Height);
        }
        public static SizeF Div(this SizeF size1, SizeF size2)
        {
            return new SizeF(size1.Width / size2.Width, size1.Height / size2.Height);
        }
    }
}
