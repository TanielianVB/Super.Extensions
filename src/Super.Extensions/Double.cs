﻿using System;

namespace Super.Extensions
{
    /// <summary>
    /// Extensions to double.
    /// </summary>
    public static class DoubleExtensions
    {
        #region Math

        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        /// <param name="x">A double-precision floating-point number to be raised to a power.</param>
        /// <param name="y">A double-precision floating-point number that specifies a power.</param>
        /// <returns>The number x raised to the power y.</returns>
        public static double Pow(this double x, double y) => Math.Pow(x, y);

        #endregion

        #region TimeSpan

        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of milliseconds.
        /// </summary>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Milliseconds(this double value) => TimeSpan.FromMilliseconds(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of seconds, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of seconds, accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Seconds(this double value) => TimeSpan.FromSeconds(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of minutes, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of minutes, accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.-or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Minutes(this double value) => TimeSpan.FromMinutes(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of hours, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of hours accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue. -or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Hours(this double value) => TimeSpan.FromHours(value);
        /// <summary>
        /// Returns a System.TimeSpan that represents a specified number of days, where the specification is accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of days, accurate to the nearest millisecond.</param>
        /// <returns>An object that represents value.</returns>
        /// <exception cref="System.OverflowException">value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue. -or-value is System.Double.PositiveInfinity.-or-value is System.Double.NegativeInfinity.</exception>
        /// <exception cref="System.ArgumentException">value is equal to System.Double.NaN.</exception>
        public static TimeSpan Days(this double value) => TimeSpan.FromDays(value);

        #endregion

        #region Units

        /// <summary>
        /// Kilo.
        /// </summary>
        public static double K(this double value) => value * 1000;
        /// <summary>
        /// Mega.
        /// </summary>
        public static double M(this double value) => value * 1000.Pow(2);
        /// <summary>
        /// Giga.
        /// </summary>
        public static double G(this double value) => value * 1000.Pow(3);
        /// <summary>
        /// Tera.
        /// </summary>
        public static double T(this double value) => value * 1000.Pow(4);
        /// <summary>
        /// Peta.
        /// </summary>
        public static double P(this double value) => value * 1000.Pow(5);
        /// <summary>
        /// Exa.
        /// </summary>
        public static double E(this double value) => value * 1000.Pow(6);

        /// <summary>
        /// Kibi.
        /// </summary>
        public static double Ki(this double value) => value * 1024;
        /// <summary>
        /// Mebi.
        /// </summary>
        public static double Mi(this double value) => value * 1024.Pow(2);
        /// <summary>
        /// Gibi.
        /// </summary>
        public static double Gi(this double value) => value * 1024.Pow(3);
        /// <summary>
        /// Tebi.
        /// </summary>
        public static double Ti(this double value) => value * 1024.Pow(4);
        /// <summary>
        /// Pebi.
        /// </summary>
        public static double Pi(this double value) => value * 1024.Pow(5);
        /// <summary>
        /// Exbi.
        /// </summary>
        public static double Ei(this double value) => value * 1024.Pow(6);

        #endregion
    }
}
