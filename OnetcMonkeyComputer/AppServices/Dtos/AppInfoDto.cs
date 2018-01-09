using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.AppServices.Dtos
{
    public class AppInfoDto
    {
        public string name { get; set; }

        public string description { get; set; }

        public string url { get; set; }

        public long newestVersion { get; set; }

        public long stableVersion { get; set; }

        public string thumbnail { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public AppType type { get; set; }

        /// <summary>
        /// 最低可用版本，低于此版本禁止使用，必须升级
        /// </summary>
        public int minVersionCode { get; set; }

        /// <summary>
        /// 是否可用，为false表示，该app已经禁止使用
        /// </summary>
        public bool isEnable { get; set; }

        /// <summary>
        /// 禁用原因
        /// </summary>
        public string disableReason { get; set; }
    }
}
