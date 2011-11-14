using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace BoletoElectronicoDesktop
{
    public static class Encriptar
    {

        public static string sha256(string input)
        {

            // Create a new instance of the MD5CryptoServiceProvider object.
            SHA256 shaHasher = SHA256CryptoServiceProvider.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = shaHasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();

        }
 
    }
}