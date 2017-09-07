using System;
using Xunit;

namespace Super.Extensions.Tests
{
    public class StringExtensionsTests
    {
        #region Convert

        [InlineData("")]
        [InlineData("AQ==")]
        [InlineData("AQID")]
        [Trait("string", "FromBase64String")]
        [Theory(DisplayName = "FromBase64String")]
        public void FromBase64StringTest(string s) => Assert.Equal(Convert.FromBase64String(s), s.FromBase64String());

        [InlineData(null)]
        [Trait("string", "FromBase64String")]
        [Theory(DisplayName = "FromBase64String")]
        public void FromBase64StringArgumentNullExceptionErrorTest(string s) => Assert.Throws<ArgumentNullException>(() => s.FromBase64String());

        [InlineData("A")]
        [Trait("string", "FromBase64String")]
        [Theory(DisplayName = "FromBase64String")]
        public void FromBase64StringFormatExceptionErrorTest(string s) => Assert.Throws<FormatException>(() => s.FromBase64String());

        #endregion

        #region String

        [InlineData("value", "value")]
        [InlineData("", "")]
        [InlineData(null, "")]
        [Trait("string", "EmptyIfNull")]
        [Theory(DisplayName = "EmptyIfNull")]
        public void EmptyIfNullTest(string value, string result) => Assert.Equal(value.EmptyIfNull(), result);

        [InlineData("Test", new object[] { }, "Test")]
        [InlineData("Test {0}", new object[] { 1 }, "Test 1")]
        [InlineData("Test {0} {1} {2}", new object[] { 1, 2, 3 }, "Test 1 2 3")]
        [Trait("string", "FormatWith")]
        [Theory(DisplayName = "FormatWith")]
        public void FormatWithTest(string value, object[] args, string result) => Assert.Equal(value.FormatWith(args), result);

        [InlineData(null, new object[] { })]
        [InlineData("Test", null)]
        [Trait("string", "FormatWith")]
        [Theory(DisplayName = "FormatWith")]
        public void FormatWithArgumentNullExceptionErrorTest(string value, object[] args) => Assert.Throws<ArgumentNullException>(() => value.FormatWith(args));

        [InlineData("Test {0}", new object[] { })]
        [Trait("string", "FormatWith")]
        [Theory(DisplayName = "FormatWith")]
        public void FormatWithFormatExceptionErrorTest(string value, object[] args) => Assert.Throws<FormatException>(() => value.FormatWith(args));

        [InlineData(null)]
        [InlineData("")]
        [Trait("string", "IsNullOrEmpty")]
        [Theory(DisplayName = "IsNullOrEmpty")]
        public void IsNullOrEmptyTest(string value) => Assert.True(value.IsNullOrEmpty());

        [InlineData("value")]
        [Trait("string", "IsNullOrEmpty")]
        [Theory(DisplayName = "IsNullOrEmpty")]
        public void NotIsNullOrEmptyTest(string value) => Assert.False(value.IsNullOrEmpty());

        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("   ")]
        [Trait("string", "IsNullOrWhiteSpace")]
        [Theory(DisplayName = "IsNullOrWhiteSpace")]
        public void IsNullOrWhiteSpaceTest(string value) => Assert.True(value.IsNullOrWhiteSpace());

        [InlineData("value")]
        [Trait("string", "IsNullOrWhiteSpace")]
        [Theory(DisplayName = "IsNullOrWhiteSpace")]
        public void NotIsNullOrWhiteSpaceTest(string value) => Assert.False(value.IsNullOrWhiteSpace());

        #endregion
    }
}
