using System.Security.Cryptography;
using System.Text;

namespace SmiteApiLib.Ressources.Helpers
{
    internal static class MD5Helper
    {
        internal static string CreateMD5Hash(string input)
        {
            var md5 = MD5.Create();
            var bytes = Encoding.UTF8.GetBytes(input);
            bytes = md5.ComputeHash(bytes);
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

    }
}