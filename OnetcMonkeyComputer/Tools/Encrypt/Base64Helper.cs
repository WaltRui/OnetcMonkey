using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Tools.Encrypt
{
    public class Base64Helper
    {
        /// <summary> /// 将字符串使用base64算法加密   
        /// </summary>   
        /// <param name="code_type">编码类型（编码名称）   
        /// </param>   
        /// <param name="code">待加密的字符串</param>   
        /// <returns>加密后的字符串</returns>   
        public static string EncodeBase64(string code_type, string code)
        {
            string encode = "";
            byte[] bytes = Encoding.GetEncoding(code_type).GetBytes(code); //将一组字符编码为一个字节序列.   
            try
            {
                encode = Convert.ToBase64String(bytes); //将8位无符号整数数组的子集转换为其等效的,以64为基的数字编码的字符串形式.   
            }
            catch
            {
                encode = code;
            }
            return encode;
        }

        public static string EncodeBase64(string code)
        {
            string encode = "";
            byte[] bytes = Encoding.UTF8.GetBytes(code); //将一组字符编码为一个字节序列.   
            try
            {
                encode = Convert.ToBase64String(bytes); //将8位无符号整数数组的子集转换为其等效的,以64为基的数字编码的字符串形式.   
            }
            catch
            {
                encode = code;
            }
            return encode;
        }

        /// <summary>   
        /// 将字符串使用base64算法解密   
        /// </summary>   
        /// <param name="code_type">编码类型</param>   
        /// <param name="code">已用base64算法加密的字符串</param>   
        /// <returns>解密后的字符串</returns>   
        public static string DecodeBase64(string code_type, string code)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(code); //将2进制编码转换为8位无符号整数数组.   
            try
            {
                decode = Encoding.GetEncoding(code_type).GetString(bytes); //将指定字节数组中的一个字节序列解码为一个字符串。   
            }
            catch
            {
                decode = code;
            }
            return decode;
        }

        public static string DecodeBase64(string code)
        {
            string decode = null;
            try
            {
                byte[] bytes = Convert.FromBase64String(code); //将2进制编码转换为8位无符号整数数组.   
                try
                {
                    decode = Encoding.UTF8.GetString(bytes); //将指定字节数组中的一个字节序列解码为一个字符串。   
                }
                catch
                {
                    decode = code;
                }
            }
            catch { }
            return decode;
        }
    }
}