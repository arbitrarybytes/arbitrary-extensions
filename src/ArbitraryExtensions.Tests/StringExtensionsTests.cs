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

    }
}