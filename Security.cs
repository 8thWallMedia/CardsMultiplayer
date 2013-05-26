/*  
 * Class: Security.cs
 * Purpose: Encrypt sensative data prior to transit
 * Author: Cameron 
*/
using System;
using System.Text;
using System.Security.Cryptography;

namespace CardsMultiplayer
{
    class Security
    {
        public static string md5(string toconvert)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return GetMd5Hash(md5Hash, toconvert);
            }
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
