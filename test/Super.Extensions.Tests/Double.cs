using System;
using Xunit;

namespace Super.Extensions.Tests
{
    public class DoubleExtensionsTests
    {
        #region Math

        [InlineData(-100, -100)]
        [InlineData(-1, -1)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(100, 100)]
        [Trait("double", "Pow")]
        [Theory(DisplayName = "Pow")]
        public void PowTest(double x, double y) => Assert.Equal(Math.Pow(x, y), x.Pow(y));

        #endregion

        #region Units

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "K")]
        [Theory(DisplayName = "K")]
        public void KTest(double x) => Assert.Equal(x * 1000, x.K());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "M")]
        [Theory(DisplayName = "M")]
        public void MTest(double x) => Assert.Equal(x * Math.Pow(1000, 2), x.M());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "G")]
        [Theory(DisplayName = "G")]
        public void GTest(double x) => Assert.Equal(x * Math.Pow(1000, 3), x.G());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "T")]
        [Theory(DisplayName = "T")]
        public void TTest(double x) => Assert.Equal(x * Math.Pow(1000, 4), x.T());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "P")]
        [Theory(DisplayName = "P")]
        public void PTest(double x) => Assert.Equal(x * Math.Pow(1000, 5), x.P());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "E")]
        [Theory(DisplayName = "E")]
        public void ETest(double x) => Assert.Equal(x * Math.Pow(1000, 6), x.E());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "Ki")]
        [Theory(DisplayName = "Ki")]
        public void KiTest(double x) => Assert.Equal(x * 1024, x.Ki());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "Mi")]
        [Theory(DisplayName = "Mi")]
        public void MiTest(double x) => Assert.Equal(x * Math.Pow(1024, 2), x.Mi());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "Gi")]
        [Theory(DisplayName = "Gi")]
        public void GiTest(double x) => Assert.Equal(x * Math.Pow(1024, 3), x.Gi());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "Ti")]
        [Theory(DisplayName = "Ti")]
        public void TiTest(double x) => Assert.Equal(x * Math.Pow(1024, 4), x.Ti());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "Pi")]
        [Theory(DisplayName = "Pi")]
        public void PiTest(double x) => Assert.Equal(x * Math.Pow(1024, 5), x.Pi());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("double", "Ei")]
        [Theory(DisplayName = "Ei")]
        public void EiTest(double x) => Assert.Equal(x * Math.Pow(1024, 6), x.Ei());

        #endregion
    }
}
