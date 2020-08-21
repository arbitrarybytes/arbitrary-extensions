using System;
using ArbitraryExtensions.Core;
using NUnit.Framework;

namespace ArbitraryExtensions.Tests
{
    [TestFixture]
    public class DateTimeExtensionsTests
    {
        static readonly DateTime today = DateTime.Now;

        [Test]
        public void TestIsInRange()
        {
            var daysAgo = DateTime.Now.AddDays(-10);
            //Assert.IsTrue(DateTime.Now.AddDays(-5).IsInRange(today, daysAgo));
        }
    }
}