using System;
using Xunit;

namespace Super.Extensions.Tests
{
    public class IntExtensionsTests
    {
        #region Math

        [InlineData(-100, -100)]
        [InlineData(-1, -1)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(100, 100)]
        [Trait("int", "Pow")]
        [Theory(DisplayName = "Pow")]
        public void PowTest(int x, int y) => Assert.Equal(Math.Pow(x, y), x.Pow(y));

        #endregion
    }
}
