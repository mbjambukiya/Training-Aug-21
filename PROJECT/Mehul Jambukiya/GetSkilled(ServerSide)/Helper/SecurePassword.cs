using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSkilled.Helper
{
    public class SecurePassword
    {
        private static string Key = "SecretKey@123456";
        public static string EncodePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "";
            }
            else
            {
                password += Key;
                var passwordBytes = Encoding.UTF8.GetBytes(password);
                return Convert.ToBase64String(passwordBytes);
            }
        }
        public static string DecodePassword(string encodedPassword)
        {
            if (string.IsNullOrEmpty(encodedPassword))
            {
                return "";
            }
            else
            {
                var passwordBytes = Convert.FromBase64String(encodedPassword);
                var decodedPassword = Encoding.UTF8.GetString(passwordBytes);
                decodedPassword = decodedPassword.Substring(0, decodedPassword.Length - Key.Length);
                return decodedPassword;
            }
        }
    }
}
