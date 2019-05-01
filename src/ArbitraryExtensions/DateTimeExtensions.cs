using System;
using System.Collections.Generic;
using System.Text;

namespace ArbitraryExtensions
{
    public static class DateTimeExtensions
    {
        public static int Age(this DateTime value)
        {
            if (DateTime.Today.Month < value.Month ||
               DateTime.Today.Month == value.Month &&
                DateTime.Today.Day < value.Day)
            {
                return DateTime.Today.Year - value.Year - 1;
            }

            return DateTime.Today.Year - value.Year;
        }
    }
}
