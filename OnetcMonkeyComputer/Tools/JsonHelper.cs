using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Tools
{
    public class JsonHelper
    {
        #region 使用  NewtonSoft Json
        public static string ObjectToJson(object obj)
        {
            string output = JsonConvert.SerializeObject(obj);
            return output;
        }
        public static T JsonToObject<T>(string jsonString)
        {
            T t = JsonConvert.DeserializeObject<T>(jsonString);
            return t;
        }
        #endregion
    }
}
