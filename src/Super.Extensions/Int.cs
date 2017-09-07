using System;
using System.Collections.Generic;
using System.Text;

namespace Super.Extensions
{
    /// <summary>
    /// Extensions to int.
    /// </summary>
    public static class IntExtensions
    {
        #region Math

        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        /// <param name="x">A int number to be raised to a power.</param>
        /// <param name="y">A double-precision floating-point number that specifies a power.</param>
        /// <returns>The number x raised to the power y.</returns>
        public static double Pow(this int x, double y) => Math.Pow(x, y);

        #endregion
    }
}
