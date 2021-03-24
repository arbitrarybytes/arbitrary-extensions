using ArbitraryExtensions.Core;
using System;
using Xunit;

namespace ArbitraryExtensions.Tests
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void TestIsInRange()
        {
            var start = new DateTime(2020, 1, 1);
            var end = new DateTime(2020, 2, 1);
            var inRange = new DateTime(2020, 1, 5);

            Assert.True(inRange.IsInRange(start, end));
        }

        [Fact]
        public void TestElapsed()
        {
            var start = new DateTime(2020, 1, 1);
            var end = new DateTime(2020, 2, 1);

            Assert.Equal((end - start), start.Elapsed(end));
        }
    }
}