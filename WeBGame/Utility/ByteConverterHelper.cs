using System;
using Newtonsoft.Json;

namespace WeBGame.Utility
{
    /// <summary>
    /// Byte与Object转换帮助类
    /// </summary>
    public class ByteConverterHelper
    {
        public static byte[] ObjectToBytes(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return System.Text.Encoding.UTF8.GetBytes(json);
        }

        public static object BytesToObject(byte[] bytes)
        {
            string json = System.Text.Encoding.UTF8.GetString(bytes);
            return JsonConvert.DeserializeObject<object>(json);
        }

        public static T BytesToObject<T>(byte[] bytes)
        {
            string json = System.Text.Encoding.UTF8.GetString(bytes);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}