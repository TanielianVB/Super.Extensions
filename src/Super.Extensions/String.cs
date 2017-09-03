﻿namespace Super.Extensions
{
    /// <summary>
    /// Extensions to string.
    /// </summary>
    public static class StringExtensions
    {
        #region String
        
        /// <summary>
        /// Indicates whether the specified string is null or an System.String.Empty string.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);
        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the value parameter is null or System.String.Empty, or if value consists exclusively of white-space characters; otherwise, false.</returns>
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

        #endregion
    }
}
