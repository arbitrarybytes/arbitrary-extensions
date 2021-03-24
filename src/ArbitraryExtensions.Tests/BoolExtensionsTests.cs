
using ArbitraryExtensions.Core;
using Xunit;

namespace ArbitraryExtensions.Tests
{

    public class BoolExtensionsTests
    {
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void TestToggle(bool input, bool expect)
        {
            Assert.Equal(expect, input.Toggle());
        }

        [Theory]
        [InlineData(true, false, false)]
        [InlineData(false, false, true)]
        [InlineData(false, true, true)]
        [InlineData(true, true, false)]
        [InlineData(null, true, true)]
        [InlineData(null, false, null)]
        public void TestToggleNullable(bool? input, bool toggleNull, bool? expect)
        {
            Assert.Equal(expect, input.Toggle(toggleNull));
        }
    }
}