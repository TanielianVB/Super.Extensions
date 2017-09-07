using Xunit;

namespace Super.Extensions.Tests
{
    public class StringExtensionsTests
    {
        #region String

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
