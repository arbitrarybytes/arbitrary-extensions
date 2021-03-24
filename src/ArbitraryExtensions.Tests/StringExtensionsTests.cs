using ArbitraryExtensions.Core;
using Xunit;

namespace ArbitraryExtensions.Tests
{

    public class StringExtensionsTests
    {

        [Theory]
        [InlineData(null, default(string))]
        [InlineData("", default(string))]
        [InlineData("Value", "Value")]
        [InlineData(" ", " ")]
        public void TestDefaultIfNullOrEmpty(string value, string expect)
        {
            Assert.Equal(expect, value.DefaultIfNullOrEmpty());
        }

        [Theory]
        [InlineData(null, null, null)]
        [InlineData(null, "Default", "Default")]
        [InlineData("", "Default", "Default")]
        [InlineData(" ", "Default", " ")]
        public void TestDefaultIfNullOrEmptyWithDefaultValue(string value, string defaultValue, string expect)
        {
            Assert.Equal(expect, value.DefaultIfNullOrEmpty(defaultValue));
        }

        [Theory]
        [InlineData(null, default(string))]
        [InlineData("", default(string))]
        [InlineData("Value", "Value")]
        [InlineData(" ", default(string))]
        [InlineData("\n", default(string))]
        [InlineData("\r", default(string))]
        [InlineData("\t", default(string))]
        public void TestDefaultIfNullOrWhitespace(string value, string expect)
        {
            Assert.Equal(expect, value.DefaultIfNullOrWhitespace());
        }

        [Theory]
        [InlineData(null, null, default(string))]
        [InlineData(null, "Default", "Default")]
        [InlineData("", "Default", "Default")]
        [InlineData(" ", "Default", "Default")]
        [InlineData("\r", "Default", "Default")]
        [InlineData("\n", "Default", "Default")]
        [InlineData("\t", "Default", "Default")]
        public void TestDefaultIfNullOrWhitespaceWithDefaultValue(string value, string defaultValue, string expect)
        {
            Assert.Equal(expect, value.DefaultIfNullOrWhitespace(defaultValue));
        }

        [Theory]
        [InlineData("this is a lowercase statement", false, "This Is A Lowercase Statement")]
        [InlineData("MS VS", false, "MS VS")]
        [InlineData("MASKS", true, "Masks")]
        [InlineData("", false, "")]
        public void TestTitleCase(string value, bool includeAllCaps, string expect)
        {
            Assert.Equal(expect, value.ToTitleCase(includeAllCaps));
        }

        [Theory]
        [InlineData("Echo the input", "Echo the input")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, "")]
        public void TestEmptyIfNull(string value, string expect)
        {
            Assert.Equal(expect, value.EmptyIfNull());
        }

        [Theory]
        [InlineData("a", "a", true)]
        [InlineData("a", "A", true)]
        [InlineData("a", "B", false)]
        public void TestEqualsIgnoreCase(string strA, string strB, bool expect)
        {
            Assert.Equal(expect, strA.EqualsIgnoreCase(strB));
        }

        [Theory]
        [InlineData("", "dot", false)]
        [InlineData(null, "dot", false)]
        [InlineData(null, null, false)]
        [InlineData("dotnet string", null, false)]
        [InlineData("dotnet string extensions", "dot", true)]
        [InlineData("dotnet string extensions", "Dot", true)]
        [InlineData("dotnet string extensions", "DOT", true)]
        [InlineData("dotnet string extensions", "net", false)]
        [InlineData("dotnet string extensions net", "net", false)]
        public void TestStartsWithIgnoreCase(string value, string prefix, bool expect)
        {
            Assert.Equal(expect, value.StartsWithIgnoreCase(prefix));
        }

        [Theory]
        [InlineData("", "dot", false)]
        [InlineData(null, "dot", false)]
        [InlineData(null, null, false)]
        [InlineData("net string dot", null, false)]
        [InlineData("net string extensions dot", "dot", true)]
        [InlineData("net string extensions dot", "Dot", true)]
        [InlineData("net string extensions dot", "DOT", true)]
        [InlineData("net string extensions dot ", "dot", false)]
        [InlineData("net string extensions net", "dot", false)]
        public void TestEndsWithIgnoreCase(string value, string prefix, bool expect)
        {
            Assert.Equal(expect, value.EndsWithIgnoreCase(prefix));
        }
    }
}