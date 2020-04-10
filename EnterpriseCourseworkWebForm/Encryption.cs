using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace EnterpriseCourseworkWebForm
{
    static public class Encryption
    {
        static public string Encrypt(string source)
        {
            byte[] encPasswordBytes = Encoding.ASCII.GetBytes(source);
            var s = SHA256.Create();

            for (int i = 0; i < 1200; i++)
            {
                encPasswordBytes = s.ComputeHash(encPasswordBytes);
            }

            StringBuilder sb = new StringBuilder(encPasswordBytes.Length);

            foreach (byte b in encPasswordBytes)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }


    }
}