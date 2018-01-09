using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnetcMonkeyComputer.Services.HnbcServices.Dtos;
using System.Net;
using System.IO;
using OnetcMonkeyComputer.AppServices.Dtos;
using OnetcMonkeyComputer.Tools;
using OnetcMonkeyComputer.Config;

namespace OnetcMonkeyComputer.Services.HnbcServices
{
    /// <summary>
    /// 该服务类提供与服务器连接查询相关数据的服务
    /// </summary>
    public class HnbcService : IHnbcService
    {
        private IConfigService _configService;
        private AppConfig config;
        public HnbcService()
        {
            _configService = new ConfigService();
            config = _configService.ReadConfig();
        }

        public List<NewsDto> GetNews()
        {
            string result = string.Empty;
            string url = AppConst.GetNewsUrl;

            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "GET";
            wbRequest.Headers.Add("authorization", "Bearer " + config.ServerToken);
            
            HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
            using (Stream responseStream = wbResponse.GetResponseStream())
            {
                using (StreamReader sReader = new StreamReader(responseStream))
                {
                    result = sReader.ReadToEnd();
                }
            }
            HnbcResponseDto<List<NewsDto>> output = JsonHelper.JsonToObject<HnbcResponseDto<List<NewsDto>>>(result);
            if (!output.Success)
                throw new Exception(output.Error);

            return output.Result;
        }

        public List<OverViewDataDto> GetOverViews(string day)
        {
            string result = string.Empty;
            string url = AppConst.GetOverViewDataUrl;

            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "GET";
            wbRequest.Headers.Add("authorization", "Bearer " + config.ServerToken);


            HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
            using (Stream responseStream = wbResponse.GetResponseStream())
            {
                using (StreamReader sReader = new StreamReader(responseStream))
                {
                    result = sReader.ReadToEnd();
                }
            }
            HnbcResponseDto<List< OverViewDataDto >> output = JsonHelper.JsonToObject<HnbcResponseDto<List<OverViewDataDto>>>(result);
            if (!output.Success)
                throw new Exception(output.Error);


            return output.Result;
            
        }
    }
}
