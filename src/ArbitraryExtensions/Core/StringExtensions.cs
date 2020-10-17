using System;

namespace ArbitraryExtensions.Core
{
    public static class StringExtensions
    {
        /// <summary>Checks if the provided input is null or empty and returns the provided default value instead.</summary>
        /// <param name="input">the value to check</param>
        /// <param name="defaultValue">the default value to return if input is null or empty, optional.</param>
        /// <returns>input if it's not null or empty, otherwise the provided default value.</returns>
        public static string DefaultIfNullOrEmpty(this string input, string defaultValue = default) => string.IsNullOrEmpty(input) ? defaultValue : input;

        /// <summary>Checks if the provided input is null or whitespace and returns the provided default value instead.</summary>
        /// <param name="input">the value to check</param>
        /// <param name="defaultValue">optional, the default value to return if input is null or whitespace.</param>
        /// <returns>input if it's not null or whitespace, otherwise the provided default value.</returns>
        public static string DefaultIfNullOrWhitespace(this string input, string defaultValue = default) => string.IsNullOrWhiteSpace(input) ? defaultValue : input;

        /// <summary>Checks the provided input string and returns string.Empty if null</summary>
        /// <param name="input">the value to check</param>
        /// <returns>string.Empty if input is null, else the provided input</returns>
        public static string EmptyIfNull(this string input) => input ?? string.Empty;

        /// <summary>Converts the provided text into title case.</summary>
        /// <param name="text">the input text to transform</param>
        /// <param name="includeAllCaps">set this flag to transform abbreviations and all caps input, defaults to false</param>
        /// <returns>the provided text input to title case</returns>
        public static string ToTitleCase(this string text, bool includeAllCaps = false)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;
            var textInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(includeAllCaps ? text.ToLower() : text);
        }

        /// <summary>
        /// Compares the provided inputs, ignoring case
        /// </summary>
        /// <param name="value">string input</param>
        /// <param name="compareTo">string to compare</param>
        /// <returns>True, if strings match ignoring the case, otherwise false</returns>
        public static bool EqualsIgnoreCase(this string value, string compareTo)
        {
            return string.Compare(value, compareTo, StringComparison.InvariantCultureIgnoreCase) == 0;
        }

        /// <summary>
        /// Checks if the provided input starts with the suffix value, ignoring case
        /// </summary>
        /// <param name="value">the input string</param>
        /// <param name="prefix">the suffix value</param>
        /// <returns>True, if value starts with suffix, ignoring case, otherwise False</returns>
        public static bool StartsWithIgnoreCase(this string value, string prefix)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(prefix)) return false;

            return value.StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Checks if the provided input ends with the suffix value, ignoring case
        /// </summary>
        /// <param name="value">the input string</param>
        /// <param name="suffix">the suffix value</param>
        /// <returns>True, if value ends with suffix, ignoring case, otherwise False</returns>
        public static bool EndsWithIgnoreCase(this string value, string suffix)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(suffix)) return false;

            return value.EndsWith(suffix, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
