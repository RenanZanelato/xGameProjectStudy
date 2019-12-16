using System;
using System.Collections.Generic;
using System.Text;

namespace xGame.Domain.Extensions
{
    public static class StringExtension
    {
        public static string ConverToMD5(this string password)
        {
            StringBuilder sbString = new StringBuilder();
            foreach (var t in System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.Default.GetBytes(password)))
            {
                sbString.Append(t.ToString("x2"));
            }
            return sbString.ToString();
        }
    }
}
