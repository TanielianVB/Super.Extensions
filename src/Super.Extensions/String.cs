using System;

namespace Super.Extensions
{
    /// <summary>
    /// Extensions to string.
    /// </summary>
    public static class StringExtensions
    {
        #region Convert

        /// <summary>
        /// Converts the specified string, which encodes binary data as base-64 digits, to an equivalent 8-bit unsigned integer array.
        /// </summary>
        /// <param name="s">The string to convert.</param>
        /// <returns>An array of 8-bit unsigned integers that is equivalent to s.</returns>
        /// <exception cref="System.ArgumentNullException">s is null.</exception>
        /// <exception cref="System.FormatException">The length of s, ignoring white-space characters, is not zero or a multiple of 4. -or-The format of s is invalid. s contains a non-base-64 character, more than two padding characters, or a non-white space-character among the padding characters.</exception>
        public static byte[] FromBase64String(this string s) => Convert.FromBase64String(s);

        #endregion

        #region String

        /// <summary>
        /// Returns empty string if the <paramref name="value"/> is null; otherwise, the <paramref name="value"/> itself.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>Empty string if the <paramref name="value"/> is null; otherwise, the <paramref name="value"/> itself.</returns>
        public static string EmptyIfNull(this string value) => value ?? string.Empty;

        /// <summary>
        /// Replaces one or more format items in a specified string with the string representation of a specified object.
        /// </summary>
        /// <param name="value">A composite format string.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <returns>A copy of format in which the format items have been replaced by the string representation of the corresponding objects in args.</returns>
        /// <exception cref="System.ArgumentNullException">format or args is null.</exception>
        /// <exception cref="System.FormatException">format is invalid.-or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
        public static string FormatWith(this string value, params object[] args) => string.Format(value, args);

        /// <summary>
        /// Indicates whether the specified string is null or an string.Empty string.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or string.Empty, or if value consists exclusively of white-space characters; otherwise, false.</returns>
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

        #endregion
    }
}
