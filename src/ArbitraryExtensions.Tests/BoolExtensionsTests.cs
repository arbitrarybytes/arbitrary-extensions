
using ArbitraryExtensions.Core;

using NUnit.Framework;

namespace ArbitraryExtensions.Tests
{
    public class BoolExtensionsTests
    {
        [Test]
        [TestCase(true, false)]
        [TestCase(false, true)]
        public void TestToggle(bool input, bool expect)
        {
            Assert.AreEqual(expect, input.Toggle());
        }

        [Test]
        [TestCase(true, false, false)]
        [TestCase(false, false, true)]
        [TestCase(false, true, true)]
        [TestCase(true, true, false)]
        [TestCase(null, true, true)]
        [TestCase(null, false, null)]
        public void TestToggleNullable(bool? input, bool toggleNull, bool? expect)
        {
            Assert.AreEqual(expect, input.Toggle(toggleNull));
        }
    }
}