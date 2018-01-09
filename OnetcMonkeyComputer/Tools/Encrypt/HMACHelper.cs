using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Tools.Encrypt
{
    public class HMACHelper
    {
        public static string EncodeHMAC(string message, string key)
        {

            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(key);

            //HMACMD5 hmacmd5 = new HMACMD5(keyByte);
            HMACSHA1 hmacsha1 = new HMACSHA1(keyByte);

            byte[] messageBytes = encoding.GetBytes(message);
            // byte[] hashmessage = hmacmd5.ComputeHash(messageBytes);
            // this.hmac1.Text = ByteToString(hashmessage);

            byte[] hashmessage = hmacsha1.ComputeHash(messageBytes);
            return ByteToString(hashmessage);

        }
        public static string ByteToString(byte[] buff)
        {
            string sbinary = "";

            for (int i = 0; i < buff.Length; i++)
            {
                sbinary += buff[i].ToString("X2"); // hex format
            }
            return (sbinary);
        }
        
    }
}
