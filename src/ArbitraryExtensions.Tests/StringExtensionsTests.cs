using ArbitraryExtensions.Core;

using NUnit.Framework;

namespace ArbitraryExtensions.Tests
{

    [TestFixture]
    public class StringExtensionsTests
    {

        [Test]
        [TestCase(null, default(string))]
        [TestCase("", default(string))]
        [TestCase("Value", "Value")]
        [TestCase(" ", " ")]
        public void TestDefaultIfNullOrEmpty(string value, string expect)
        {
            Assert.AreEqual(expect, value.DefaultIfNullOrEmpty());
        }

        [Test]
        [TestCase(null, null, null)]
        [TestCase(null, default(string), default(string))]
        [TestCase(null, "Default", "Default")]
        [TestCase("", "Default", "Default")]
        [TestCase(" ", "Default", " ")]
        public void TestDefaultIfNullOrEmptyWithDefaultValue(string value, string defaultValue, string expect)
        {
            Assert.AreEqual(expect, value.DefaultIfNullOrEmpty(defaultValue));
        }

        [Test]
        [TestCase(null, default(string))]
        [TestCase("", default(string))]
        [TestCase("Value", "Value")]
        [TestCase(" ", default(string))]
        [TestCase("\n", default(string))]
        [TestCase("\r", default(string))]
        [TestCase("\t", default(string))]
        public void TestDefaultIfNullOrWhitespace(string value, string expect)
        {
            Assert.AreEqual(expect, value.DefaultIfNullOrWhitespace());
        }

        [Test]
        [TestCase(null, null, default(string))]
        [TestCase(null, default(string), default(string))]
        [TestCase(null, "Default", "Default")]
        [TestCase("", "Default", "Default")]
        [TestCase(" ", "Default", "Default")]
        [TestCase("\r", "Default", "Default")]
        [TestCase("\n", "Default", "Default")]
        [TestCase("\t", "Default", "Default")]
        public void TestDefaultIfNullOrWhitespaceWithDefaultValue(string value, string defaultValue, string expect)
        {
            Assert.AreEqual(expect, value.DefaultIfNullOrWhitespace(defaultValue));
        }

        [Test]
        [TestCase("this is a lowercase statement", false, "This Is A Lowercase Statement")]
        [TestCase("MS VS", false, "MS VS")]
        [TestCase("MASKS", true, "Masks")]
        [TestCase("", false, "")]
        public void TestTitleCase(string value, bool includeAllCaps, string expect)
        {
            Assert.AreEqual(expect, value.ToTitleCase(includeAllCaps));
        }

        [Test]
        [TestCase("Echo the input", "Echo the input")]
        [TestCase("", "")]
        [TestCase(" ", " ")]
        [TestCase(null, "")]
        [TestCase(default(string), "")]
        public void TestEmptyIfNull(string value, string expect)
        {
            Assert.AreEqual(expect, value.EmptyIfNull());
        }

        [Test]
        [TestCase("a", "a", true)]
        [TestCase("a", "A", true)]
        [TestCase("a", "B", false)]
        public void TestEqualsIgnoreCase(string strA, string strB, bool expect)
        {
            Assert.AreEqual(expect, strA.EqualsIgnoreCase(strB));
        }

        [Test]
        [TestCase("", "dot", false)]
        [TestCase(null, "dot", false)]
        [TestCase(null, null, false)]
        [TestCase("dotnet string", null, false)]
        [TestCase("dotnet string extensions", "dot", true)]
        [TestCase("dotnet string extensions", "Dot", true)]
        [TestCase("dotnet string extensions", "DOT", true)]
        [TestCase("dotnet string extensions", "net", false)]
        [TestCase("dotnet string extensions net", "net", false)]
        public void TestStartsWithIgnoreCase(string value, string prefix, bool expect)
        {
            Assert.AreEqual(expect, value.StartsWithIgnoreCase(prefix));
        }
        
        [Test]
        [TestCase("", "dot", false)]
        [TestCase(null, "dot", false)]
        [TestCase(null, null, false)]
        [TestCase("net string dot", null, false)]
        [TestCase("net string extensions dot", "dot", true)]
        [TestCase("net string extensions dot", "Dot", true)]
        [TestCase("net string extensions dot", "DOT", true)]
        [TestCase( "net string extensions dot ", "dot", false)]
        [TestCase("net string extensions net", "dot", false)]
        public void TestEndsWithIgnoreCase(string value, string prefix, bool expect)
        {
            Assert.AreEqual(expect, value.EndsWithIgnoreCase(prefix));
        }
    }
}