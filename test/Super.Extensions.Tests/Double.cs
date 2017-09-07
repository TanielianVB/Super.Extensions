using System;
using Xunit;

namespace Super.Extensions.Tests
{
    public class DoubleExtensionsTests
    {
        #region Math

        [InlineData(-100.1, -100.1)]
        [InlineData(-1.1, -1.1)]
        [InlineData(0, 0)]
        [InlineData(1.1, 1.1)]
        [InlineData(100.1, 100.1)]
        [Trait("double", "Pow")]
        [Theory(DisplayName = "Pow")]
        public void PowTest(double x, double y) => Assert.Equal(Math.Pow(x, y), x.Pow(y));

        #endregion

        #region TimeSpan

        [InlineData(-1_000_000_000.1)]
        [InlineData(-1.1)]
        [InlineData(0.0)]
        [InlineData(1.1)]
        [InlineData(1_000_000_000.1)]
        [Trait("double", "Milliseconds")]
        [Theory(DisplayName = "Milliseconds")]
        public void MillisecondsTest(double value) => Assert.Equal(value.Milliseconds(), TimeSpan.FromMilliseconds(value));

        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        [InlineData(double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity)]
        [Trait("double", "Milliseconds")]
        [Theory(DisplayName = "Milliseconds")]
        public void MillisecondsOverflowExceptionErrorTest(double value) => Assert.Throws<OverflowException>(() => value.Milliseconds());

        [InlineData(double.NaN)]
        [Trait("double", "Milliseconds")]
        [Theory(DisplayName = "Milliseconds")]
        public void MillisecondsArgumentExceptionErrorTest(double value) => Assert.Throws<ArgumentException>(() => value.Milliseconds());

        [InlineData(-1_000_000_000.1)]
        [InlineData(-1.1)]
        [InlineData(0.0)]
        [InlineData(1.1)]
        [InlineData(1_000_000_000.1)]
        [Trait("double", "Seconds")]
        [Theory(DisplayName = "Seconds")]
        public void SecondsTest(double value) => Assert.Equal(value.Seconds(), TimeSpan.FromSeconds(value));

        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        [InlineData(double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity)]
        [Trait("double", "Seconds")]
        [Theory(DisplayName = "Seconds")]
        public void SecondsOverflowExceptionErrorTest(double value) => Assert.Throws<OverflowException>(() => value.Seconds());

        [InlineData(double.NaN)]
        [Trait("double", "Seconds")]
        [Theory(DisplayName = "Seconds")]
        public void SecondsArgumentExceptionErrorTest(double value) => Assert.Throws<ArgumentException>(() => value.Seconds());

        [InlineData(-1_000_000_000.1)]
        [InlineData(-1.1)]
        [InlineData(0.0)]
        [InlineData(1.1)]
        [InlineData(1_000_000_000.1)]
        [Trait("double", "Minutes")]
        [Theory(DisplayName = "Minutes")]
        public void MinutesTest(double value) => Assert.Equal(value.Minutes(), TimeSpan.FromMinutes(value));

        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        [InlineData(double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity)]
        [Trait("double", "Minutes")]
        [Theory(DisplayName = "Minutes")]
        public void MinutesOverflowExceptionErrorTest(double value) => Assert.Throws<OverflowException>(() => value.Minutes());

        [InlineData(double.NaN)]
        [Trait("double", "Minutes")]
        [Theory(DisplayName = "Minutes")]
        public void MinutesArgumentExceptionErrorTest(double value) => Assert.Throws<ArgumentException>(() => value.Minutes());

        [InlineData(-1_000_000.1)]
        [InlineData(-1.1)]
        [InlineData(0.0)]
        [InlineData(1.1)]
        [InlineData(1_000_000.1)]
        [Trait("double", "Hours")]
        [Theory(DisplayName = "Hours")]
        public void HoursTest(double value) => Assert.Equal(value.Hours(), TimeSpan.FromHours(value));

        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        [InlineData(double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity)]
        [Trait("double", "Hours")]
        [Theory(DisplayName = "Hours")]
        public void HoursOverflowExceptionErrorTest(double value) => Assert.Throws<OverflowException>(() => value.Hours());

        [InlineData(double.NaN)]
        [Trait("double", "Hours")]
        [Theory(DisplayName = "Hours")]
        public void HoursArgumentExceptionErrorTest(double value) => Assert.Throws<ArgumentException>(() => value.Hours());

        [InlineData(-1_000_000.1)]
        [InlineData(-1.1)]
        [InlineData(0.0)]
        [InlineData(1.1)]
        [InlineData(1_000_000.1)]
        [Trait("double", "Days")]
        [Theory(DisplayName = "Days")]
        public void DaysTest(double value) => Assert.Equal(value.Days(), TimeSpan.FromDays(value));

        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        [InlineData(double.NegativeInfinity)]
        [InlineData(double.PositiveInfinity)]
        [Trait("double", "Days")]
        [Theory(DisplayName = "Days")]
        public void DaysOverflowExceptionErrorTest(double value) => Assert.Throws<OverflowException>(() => value.Days());

        [InlineData(double.NaN)]
        [Trait("double", "Days")]
        [Theory(DisplayName = "Days")]
        public void DaysArgumentExceptionErrorTest(double value) => Assert.Throws<ArgumentException>(() => value.Days());

        #endregion

        #region Units

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "K")]
        [Theory(DisplayName = "K")]
        public void KTest(double x) => Assert.Equal(x * 1000, x.K());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "M")]
        [Theory(DisplayName = "M")]
        public void MTest(double x) => Assert.Equal(x * Math.Pow(1000, 2), x.M());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "G")]
        [Theory(DisplayName = "G")]
        public void GTest(double x) => Assert.Equal(x * Math.Pow(1000, 3), x.G());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "T")]
        [Theory(DisplayName = "T")]
        public void TTest(double x) => Assert.Equal(x * Math.Pow(1000, 4), x.T());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "P")]
        [Theory(DisplayName = "P")]
        public void PTest(double x) => Assert.Equal(x * Math.Pow(1000, 5), x.P());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "E")]
        [Theory(DisplayName = "E")]
        public void ETest(double x) => Assert.Equal(x * Math.Pow(1000, 6), x.E());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "Ki")]
        [Theory(DisplayName = "Ki")]
        public void KiTest(double x) => Assert.Equal(x * 1024, x.Ki());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "Mi")]
        [Theory(DisplayName = "Mi")]
        public void MiTest(double x) => Assert.Equal(x * Math.Pow(1024, 2), x.Mi());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "Gi")]
        [Theory(DisplayName = "Gi")]
        public void GiTest(double x) => Assert.Equal(x * Math.Pow(1024, 3), x.Gi());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "Ti")]
        [Theory(DisplayName = "Ti")]
        public void TiTest(double x) => Assert.Equal(x * Math.Pow(1024, 4), x.Ti());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "Pi")]
        [Theory(DisplayName = "Pi")]
        public void PiTest(double x) => Assert.Equal(x * Math.Pow(1024, 5), x.Pi());

        [InlineData(-100.1)]
        [InlineData(-1.1)]
        [InlineData(0)]
        [InlineData(1.1)]
        [InlineData(100.1)]
        [Trait("double", "Ei")]
        [Theory(DisplayName = "Ei")]
        public void EiTest(double x) => Assert.Equal(x * Math.Pow(1024, 6), x.Ei());

        #endregion
    }
}
