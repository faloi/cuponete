using GrouponDesktop.Helpers;
using Xunit;

namespace GrouponDesktop.Test.Helpers
{
    public class EncodingHelpersTest
    {
        [Fact]
        public void Can_correctly_encrypt_string_using_sha256()
        {
            var toEncrypt = "demo";
            Assert.Equal("2a97516c354b68848cdbd8f54a226a0a55b21ed138e207ad6c5cbb9c00aa5aea", toEncrypt.ToSha256());
        }
    }
}
