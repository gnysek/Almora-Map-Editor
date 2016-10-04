using System.Globalization;
using System.Windows.Forms;

namespace MapEditor.Common
{
    class Helper
    {
        public static float getDirFromInput(TextBox t)
        {

            return parseToFloat(t.Text);
        }

        public static float parseToFloat(string s)
        {
            float a = 0.0f;
            float.TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out a);
            return a;
        }
    }
}
