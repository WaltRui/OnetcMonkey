using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnetcMonkeyComputer.AppServices.Dtos;
using System.Net;
using System.IO;
using OnetcMonkeyComputer.Tools;
using OnetcMonkeyComputer.Config;

namespace OnetcMonkeyComputer.AppServices
{
    public class AppService : IAppService
    {
        private string appinfoUrl = $"http://api.app.hnbc.info/v1/app/detail?name={AppInfo.AppName}";
        private string loginUrl = "http://api.app.hnbc.info/v1/apps/wcmonkey/auth/login";
        private string getserversUrl = $"http://api.app.hnbc.info/v1/apps/wcmonkey/servers";
        public AppInfoDto GetAppInfo()
        {
            string result = string.Empty;
            string url = appinfoUrl;
            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "GET";
            
            HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
            using (Stream responseStream = wbResponse.GetResponseStream())
            {
                using (StreamReader sReader = new StreamReader(responseStream))
                {
                    result = sReader.ReadToEnd();
                }
            }
            HnbcResponseDto<AppInfoDto> output = JsonHelper.JsonToObject<HnbcResponseDto<AppInfoDto>>(result);
            if (!output.Success)
                throw new Exception(output.Error);
            return output.Result;
        }

        public List<ServerInfo> GetServerList()
        {
            string result = string.Empty;
            string url = getserversUrl;
            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "GET";

            HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
            using (Stream responseStream = wbResponse.GetResponseStream())
            {
                using (StreamReader sReader = new StreamReader(responseStream))
                {
                    result = sReader.ReadToEnd();
                }
            }
            HnbcResponseDto<List<ServerInfo>> output = JsonHelper.JsonToObject<HnbcResponseDto<List<ServerInfo>>>(result);
            if (!output.Success)
                throw new Exception(output.Error);
            return output.Result;
        }

        public LoginResult Login(string wallet,string name)
        {
            string result = string.Empty;
            string url = loginUrl;

            var input = new LoginInput();
            input.EnCode(wallet,name);

            string param = JsonHelper.ObjectToJson(input);
            byte[] bs = Encoding.ASCII.GetBytes(param);

            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "Post";           
            wbRequest.ContentType = "application/json-patch+json";
           
            using (Stream reqStream = wbRequest.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
            }

            HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
            using (Stream responseStream = wbResponse.GetResponseStream())
            {
                using (StreamReader sReader = new StreamReader(responseStream))
                {
                    result = sReader.ReadToEnd();
                }
            }

            HnbcResponseDto<LoginResult> output = JsonHelper.JsonToObject<HnbcResponseDto<LoginResult>>(result);
            if (!output.Success)
                throw new Exception(output.Error);

            return output.Result;
        }

    }
}
