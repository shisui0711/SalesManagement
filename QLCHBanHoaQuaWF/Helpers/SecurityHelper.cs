using System.Security.Cryptography;
using System.Text;

namespace QLCHWF.Helpers;

public static class SecurityHelper
{
    public static string GetSha256Hash(string input)
    {
        using (SHA256 sha = SHA256.Create())
        {

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}