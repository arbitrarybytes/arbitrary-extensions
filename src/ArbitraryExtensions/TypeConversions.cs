using System;
using System.Collections.Generic;
using System.Text;

namespace ArbitraryExtensions
{
    public static class TypeConversions
    {
        public static int? AsNullableInt(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            return int.TryParse(value, out int result) ? result : (int?)null;
        }

        public static decimal? AsNullableDecimal(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            return decimal.TryParse(value, out decimal result) ? result : (decimal?)null;
        }

        public static DateTime? AsNullableDateTime(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            return DateTime.TryParse(value, out DateTime result) ? result : default;
        }
    }
}
