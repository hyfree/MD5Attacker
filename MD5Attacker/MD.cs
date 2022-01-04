using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5Attacker
{
    public static class MD
    {
        public static string MDString3(this string s, string salt)
        {
            using MD5 md5 = MD5.Create();
            byte[] bytes = Encoding.ASCII.GetBytes(s + salt);
            byte[] bytes1 = md5.ComputeHash(bytes);
            byte[] bytes2 = md5.ComputeHash(bytes1);
            byte[] bytes3 = md5.ComputeHash(bytes2);
            return bytes3.Aggregate("", (current, b) => current + b.ToString("x2"));
        }
        public static string MDString3(this byte[] s, byte[] salt)
        {
            using MD5 md5 = MD5.Create();
            byte[] data=new byte[s.Length+salt.Length];
            s.CopyTo(data,0);
            salt.CopyTo(data,s.Length);
           
            byte[] bytes1 = md5.ComputeHash(data);
            byte[] bytes2 = md5.ComputeHash(bytes1);
            byte[] bytes3 = md5.ComputeHash(bytes2);
            return bytes3.Aggregate("", (current, b) => current + b.ToString("x2"));
        }
    }
}