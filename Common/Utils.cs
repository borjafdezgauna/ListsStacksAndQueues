using System;
using System.Globalization;

namespace Lists
{
    public class Utils
    {
        public static string ToString(double number, int numMaxDecimalDigits = 0)
        {
            double value = number;
            if (numMaxDecimalDigits > 0)
                value = Math.Round(value, numMaxDecimalDigits);
            return value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
