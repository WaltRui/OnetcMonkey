using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Tools
{
    public class FileHelper
    {
        public static long GetFileLength(string fileFullName)
        {
            try
            {
                FileInfo f = new FileInfo(fileFullName);
                return f.Length;
            }
            catch
            {
                return 0;
            }
        }

        public static string ReadFile(string fileFullName)
        {
            string text = System.IO.File.ReadAllText(fileFullName);
            return text;

        }
        public static string ReadFileByStreamReader(string fileFullName)
        {
            StreamReader sr = new StreamReader(fileFullName, Encoding.Default);
            return sr.ReadToEnd();
        }
        public static void WriteFile(string fileFullName, string text)
        {
            System.IO.File.WriteAllText(fileFullName, text, Encoding.UTF8);
        }

        public static string GetMD5HashFromFile(string fileName)
        {
            try
            {
                FileStream file = new FileStream(fileName, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetMD5HashFromFile() fail, error:" + ex.Message);
            }
        }
    }
}
