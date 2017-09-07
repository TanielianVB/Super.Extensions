using System;
using Xunit;

namespace Super.Extensions.Tests
{
    public class ByteArrayExtensionsTests
    {
        #region Convert

        [InlineData(new byte[] { })]
        [InlineData(new byte[] { 1 })]
        [InlineData(new byte[] { 1, 2, 3 })]
        [Trait("byte[]", "ToBase64String")]
        [Theory(DisplayName = "ToBase64String")]
        public void ToBase64StringTest(byte[] inArray) => Assert.Equal(Convert.ToBase64String(inArray), inArray.ToBase64String());

        [InlineData(null)]
        [Trait("byte[]", "ToBase64String")]
        [Theory(DisplayName = "ToBase64String")]
        public void ToBase64StringArgumentNullExceptionErrorTest(byte[] inArray) => Assert.Throws<ArgumentNullException>(() => inArray.ToBase64String());

        [InlineData(new byte[] { }, 0, 0)]
        [InlineData(new byte[] { 1 }, 1, 0)]
        [InlineData(new byte[] { 1, 2, 3 }, 1, 2)]
        [Trait("byte[]", "ToBase64String")]
        [Theory(DisplayName = "ToBase64String")]
        public void ToBase64StringWithOffSetTest(byte[] inArray, int offset, int length) => Assert.Equal(Convert.ToBase64String(inArray, offset, length), inArray.ToBase64String(offset, length));

        [InlineData(null, 0, 0)]
        [Trait("byte[]", "ToBase64String")]
        [Theory(DisplayName = "ToBase64String")]
        public void ToBase64StringWithOffSetArgumentNullExceptionErrorTest(byte[] inArray, int offset, int length) => Assert.Throws<ArgumentNullException>(() => inArray.ToBase64String(offset, length));

        [InlineData(new byte[] { }, -1, 0)]
        [InlineData(new byte[] { }, 0, -1)]
        [InlineData(new byte[] { }, 1, 0)]
        [InlineData(new byte[] { }, 0, 1)]
        [Trait("byte[]", "ToBase64String")]
        [Theory(DisplayName = "ToBase64String")]
        public void ToBase64StringWithOffSetArgumentOutOfRangeExceptionErrorTest(byte[] inArray, int offset, int length) => Assert.Throws<ArgumentOutOfRangeException>(() => inArray.ToBase64String(offset, length));

        #endregion
    }
}
