using System;
namespace ArbitraryExtensions.Core
{
    public static class DateTimeExtensions
    {
        /// <summary>Gets the elapsed timespan between the provided value and DateTime.Now</summary>
        /// <param name="value">the start datetime value</param>
        /// <returns>elapsed timespan instance</returns>
        public static TimeSpan Elapsed(this DateTime value) => DateTime.Now.Subtract(value);

        /// <summary>Gets if the input date is between the provided start and end date</summary>
        /// <param name="currentDate">the input date</param>
        /// <param name="startDate">the start date</param>
        /// <param name="endDate">the end date</param>
        /// <returns>True, if the input date is within the range, else False</returns>
        public static bool IsInRange(this DateTime currentDate, DateTime startDate, DateTime endDate)
            => (currentDate >= startDate && currentDate <= endDate);
    }
}
