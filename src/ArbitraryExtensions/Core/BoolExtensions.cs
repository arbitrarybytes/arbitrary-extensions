namespace ArbitraryExtensions.Core
{
    public static class BoolExtensions
    {
        /// <summary>Toggles the provided value</summary>
        /// <param name="value">the value to toggle</param>
        /// <returns>the toggled value (true -> false or vice versa)</returns>
        public static bool Toggle(this bool value) => !value;

        /// <summary>Toggles the provided value</summary>
        /// <param name="value">the value to toggle</param>
        /// <param name="toggleNull">flag to toggle null value, defaults to false</param>
        /// <returns>toggled value, if not null, otherwise depending on toggleNull param</returns>
        public static bool? Toggle(this bool? value, bool toggleNull = false)
        {
            if (value.HasValue)
                return !value;

            return toggleNull ? true : default(bool?);
        }
    }
}