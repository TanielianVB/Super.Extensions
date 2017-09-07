using System;

namespace Super.Extensions
{
    /// <summary>
    /// Extensions to byte[].
    /// </summary>
    public static class ByteArrayExtensions
    {
        #region Convert

        /// <summary>
        /// Converts an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits.
        /// </summary>
        /// <param name="inArray">An array of 8-bit unsigned integers.</param>
        /// <returns>The string representation, in base 64, of the contents of inArray.</returns>
        /// <exception cref="System.ArgumentNullException">inArray is null.</exception>
        public static string ToBase64String(this byte[] inArray) => Convert.ToBase64String(inArray);
        /// <summary>
        /// Converts a subset of an array of 8-bit unsigned integers to its equivalent string representation that is encoded with base-64 digits. Parameters specify the subset as an offset in the input array, and the number of elements in the array to convert.
        /// </summary>
        /// <param name="inArray">An array of 8-bit unsigned integers.</param>
        /// <param name="offset">An offset in inArray.</param>
        /// <param name="length">The number of elements of inArray to convert.</param>
        /// <returns>The string representation in base 64 of length elements of inArray, starting at position offset.</returns>
        /// <exception cref="System.ArgumentNullException">inArray is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">offset or length is negative.-or- offset plus length is greater than the length of inArray.</exception>
        public static string ToBase64String(this byte[] inArray, int offset, int length) => Convert.ToBase64String(inArray, offset, length);

        #endregion
    }
}
