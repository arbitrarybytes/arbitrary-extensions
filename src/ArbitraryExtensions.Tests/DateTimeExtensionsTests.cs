using System;
using ArbitraryExtensions.Core;
using NUnit.Framework;

namespace ArbitraryExtensions.Tests
{
    [TestFixture]
    public class DateTimeExtensionsTests
    {
        [Test]
        public void TestIsInRange()
        {
            var start = new DateTime(2020, 1, 1);
            var end = new DateTime(2020, 2, 1);
            var inRange = new DateTime(2020, 1, 5);

            Assert.IsTrue(inRange.IsInRange(start, end));
        }

        [Test]
        public void TestElapsed()
        {
            var start = new DateTime(2020, 1, 1);
            var end = new DateTime(2020, 2, 1);

            Assert.AreEqual((end - start), start.Elapsed(end));
        }
    }
}