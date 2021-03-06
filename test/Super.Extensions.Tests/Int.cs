﻿using System;
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
        public void PowTest(int x, double y) => Assert.Equal(Math.Pow(x, y), x.Pow(y));

        #endregion

        #region TimeSpan

        [InlineData(-1_000_000_000)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1_000_000_000)]
        [Trait("int", "Ticks")]
        [Theory(DisplayName = "Ticks")]
        public void TicksTest(int value) => Assert.Equal(value.Ticks(), TimeSpan.FromTicks(value));

        [InlineData(-1_000_000_000)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1_000_000_000)]
        [Trait("int", "Milliseconds")]
        [Theory(DisplayName = "Milliseconds")]
        public void MillisecondsTest(int value) => Assert.Equal(value.Milliseconds(), TimeSpan.FromMilliseconds(value));

        [InlineData(-1_000_000_000)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1_000_000_000)]
        [Trait("int", "Seconds")]
        [Theory(DisplayName = "Seconds")]
        public void SecondsTest(int value) => Assert.Equal(value.Seconds(), TimeSpan.FromSeconds(value));

        [InlineData(-1_000_000_000)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1_000_000_000)]
        [Trait("int", "Minutes")]
        [Theory(DisplayName = "Minutes")]
        public void MinutesTest(int value) => Assert.Equal(value.Minutes(), TimeSpan.FromMinutes(value));

        [InlineData(-1_000_000)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1_000_000)]
        [Trait("int", "Hours")]
        [Theory(DisplayName = "Hours")]
        public void HoursTest(int value) => Assert.Equal(value.Hours(), TimeSpan.FromHours(value));

        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        [Trait("int", "Hours")]
        [Theory(DisplayName = "Hours")]
        public void HoursOverflowExceptionErrorTest(int value) => Assert.Throws<OverflowException>(() => value.Hours());

        [InlineData(-1_000_000)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(1_000_000)]
        [Trait("int", "Days")]
        [Theory(DisplayName = "Days")]
        public void DaysTest(int value) => Assert.Equal(value.Days(), TimeSpan.FromDays(value));

        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        [Trait("int", "Days")]
        [Theory(DisplayName = "Days")]
        public void DaysOverflowExceptionErrorTest(int value) => Assert.Throws<OverflowException>(() => value.Days());

        #endregion

        #region Units

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "K")]
        [Theory(DisplayName = "K")]
        public void KTest(int x) => Assert.Equal(x * 1000, x.K());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "M")]
        [Theory(DisplayName = "M")]
        public void MTest(int x) => Assert.Equal(x * Math.Pow(1000, 2), x.M());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "G")]
        [Theory(DisplayName = "G")]
        public void GTest(int x) => Assert.Equal(x * Math.Pow(1000, 3), x.G());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "T")]
        [Theory(DisplayName = "T")]
        public void TTest(int x) => Assert.Equal(x * Math.Pow(1000, 4), x.T());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "P")]
        [Theory(DisplayName = "P")]
        public void PTest(int x) => Assert.Equal(x * Math.Pow(1000, 5), x.P());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "E")]
        [Theory(DisplayName = "E")]
        public void ETest(int x) => Assert.Equal(x * Math.Pow(1000, 6), x.E());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "Ki")]
        [Theory(DisplayName = "Ki")]
        public void KiTest(int x) => Assert.Equal(x * 1024, x.Ki());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "Mi")]
        [Theory(DisplayName = "Mi")]
        public void MiTest(int x) => Assert.Equal(x * Math.Pow(1024, 2), x.Mi());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "Gi")]
        [Theory(DisplayName = "Gi")]
        public void GiTest(int x) => Assert.Equal(x * Math.Pow(1024, 3), x.Gi());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "Ti")]
        [Theory(DisplayName = "Ti")]
        public void TiTest(int x) => Assert.Equal(x * Math.Pow(1024, 4), x.Ti());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "Pi")]
        [Theory(DisplayName = "Pi")]
        public void PiTest(int x) => Assert.Equal(x * Math.Pow(1024, 5), x.Pi());

        [InlineData(-100)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        [Trait("int", "Ei")]
        [Theory(DisplayName = "Ei")]
        public void EiTest(int x) => Assert.Equal(x * Math.Pow(1024, 6), x.Ei());

        #endregion
    }
}
