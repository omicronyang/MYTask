using System;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.IO;

namespace MYTask
{
    class PswString
    {

        public string MD64;
        public PswString(string ogn)
        {
            Encoding encode = Encoding.ASCII;
            //Base64 Encrypt
            byte[] data = encode.GetBytes(ogn);
            string B64result = Convert.ToBase64String(data, 0, data.Length);
            //MD5 Encrypt
            data = encode.GetBytes(B64result);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(data);
            MD64 = BitConverter.ToString(output).Replace("-", "").ToLower();
        }
    }
}
