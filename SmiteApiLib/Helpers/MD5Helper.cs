using System.Security.Cryptography;
using System.Text;

internal static class MD5Helper
{
    internal static string CreateMD5Hash(string input)
    {
        // Step 1, calculate MD5 hash from input
        var md5 = MD5.Create();
        var inputBytes = Encoding.ASCII.GetBytes(input);
        var hashBytes = md5.ComputeHash(inputBytes);

        // Step 2, convert byte array to hex string
        var sb = new StringBuilder();
        for (int i = 0; i < hashBytes.Length; i++)
        {
            sb.Append(hashBytes[i].ToString("X2"));
        }
        return sb.ToString();
    }
}