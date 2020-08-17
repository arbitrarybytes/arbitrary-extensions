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
        /// <param name="defaultValue">optional, the default value to return if input is null or whitepace.</param>
        /// <returns>input if it's not null or whitespace, otherwise the provided default value.</returns>
        public static string DefaultIfNullOrWhitespace(this string input, string defaultValue = default) => string.IsNullOrWhiteSpace(input) ? defaultValue : input;

        /// <summary>Converts the provided text into title case.</summary>
        /// <param name="text">the input text to transform</param>
        /// <param name="includeAllCaps">set this flag to transform abbreviations and all caps input, defaults to false</param>
        /// <returns>the provided text input to title case</returns>
        public static string ToTitleCase(this string text, bool includeAllCaps = false)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;
            System.Globalization.TextInfo textInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(includeAllCaps ? text.ToLower() : text);
        }


    }
}
