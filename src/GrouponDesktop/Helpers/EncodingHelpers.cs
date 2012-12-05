using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GrouponDesktop.Helpers
{
    public static class EncodingHelpers
    {
        public static string ToSha256(this string someString)
        {
            var bytes = Encoding.UTF8.GetBytes(someString);
            var hashstring = new SHA256Managed();
            var hash = hashstring.ComputeHash(bytes);
            
            return hash.Aggregate(string.Empty, (current, x) => current + string.Format("{0:x2}", x));
        }
    }
}