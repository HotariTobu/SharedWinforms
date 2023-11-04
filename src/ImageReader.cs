using System;
using System.Drawing;
using System.IO;

namespace SharedWinforms
{
    public static class ImageReader
    {
        public static Image ReadImage(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new ArgumentNullException("filename");
            }

            Image result = null;
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                result = Image.FromStream(fs);
            }
            return result;
        }
    }
}
