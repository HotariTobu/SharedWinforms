using System.Drawing;

namespace SharedWinforms
{
    /// <summary>
    /// <see cref="string"/>を他の型に変換するクラス。
    /// </summary>
    public class StringParsers
    {
        /// <summary>
        /// <see cref="string"/>を<see cref="Font"/>に変換します。<br/>
        /// 書式は[ファミリ名(<see cref="string"/>)][サイズ(<see cref="float"/>)][スタイル(<see cref="FontStyle"/>)]か<br/>
        /// [ファミリ名(<see cref="string"/>)][サイズ(<see cref="float"/>)][太字(<see cref="bool"/>)][斜体(<see cref="bool"/>)]である必要があります。
        /// </summary>
        /// <param name="defaultValue">変換できなかった場合に返される値</param>
        /// <param name="data">変換する<see cref="string"/></param>
        /// <returns>正常に変換された場合はその値、それ以外はdefaultValue</returns>
        public static Font ParseToFont(Font defaultValue, params string[] data)
        {
            if (data?.Length == 3)
            {
                if (float.TryParse(data[1], out float size) && int.TryParse(data[2], out int style))
                {
                    return new Font(data[0], size, (FontStyle)style, GraphicsUnit.Point);
                }
            }
            else if (data?.Length == 4)
            {
                if (float.TryParse(data[1], out float size) && bool.TryParse(data[2], out bool bold) && bool.TryParse(data[3], out bool italic))
                {
                    FontStyle style = FontStyle.Regular;
                    if (bold)
                    {
                        style |= FontStyle.Bold;
                    }
                    if (italic)
                    {
                        style |= FontStyle.Italic;
                    }

                    return new Font(data[0], size, style, GraphicsUnit.Point);
                }
            }

            return defaultValue;
        }

        /// <summary>
        /// <see cref="string"/>を<see cref="Color"/>に変換します。<br/>
        /// 書式は[赤(<see cref="int"/>)][緑(<see cref="int"/>)][青(<see cref="int"/>)]である必要があります。
        /// </summary>
        /// <param name="defaultValue">変換できなかった場合に返される値</param>
        /// <param name="data">変換する<see cref="string"/></param>
        /// <returns>正常に変換された場合はその値、それ以外はdefaultValue</returns>
        public static Color ParseToColor(Color defaultValue, params string[] data)
        {
            if (data?.Length == 3)
            {
                if (int.TryParse(data[0], out int red) && int.TryParse(data[1], out int green) && int.TryParse(data[2], out int blue))
                {
                    return Color.FromArgb(red, green, blue);
                }
            }

            return defaultValue;
        }
    }
}
