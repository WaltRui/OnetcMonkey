using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnetcMonkeyComputer.Services.Dtos;
using System.Net;
using System.IO;
using OnetcMonkeyComputer.Tools;
using OnetcMonkeyComputer.Services.RequestDtos;

namespace OnetcMonkeyComputer.Services
{
    public class MonkeyService : IMonkeyService
    {
        public RequestMonkeyWithUserDetailDto GetMonkeyDetail(string token, long id)
        {
            string result = string.Empty;
            string url = $"http://api.h.miguan.in/game/detail/{id}";
            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "GET";

            wbRequest.Accept = "application/json, text/plain, */*";
            wbRequest.Headers.Add("Origin", "http://h.miguan.in");
            wbRequest.Headers.Add("accessToken", token);
            wbRequest.Headers.Add("Cookie", $"token={token}; _ga=GA1.2.688806701.1811704586; _gid=GA1.8.177683714.1664296938; _gat=1");
            wbRequest.ContentType = "application/x-www-form-urlencoded";
            wbRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36";
            wbRequest.Referer = $"http://h.miguan.in/monkey/{id}";

            HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
            using (Stream responseStream = wbResponse.GetResponseStream())
            {
                using (StreamReader sReader = new StreamReader(responseStream))
                {
                    result = sReader.ReadToEnd();
                }
            }
            RequestResultDto<RequestMonkeyWithUserDetailDto> output = JsonHelper.JsonToObject<RequestResultDto<RequestMonkeyWithUserDetailDto>>(result);
            if (!output.Success)
                throw new Exception(output.Msg);
            return output.Result;
        }

        public MiguanUserInfoDto GetUserInfo(string token)
        {
            string result = string.Empty;
            string url = $"http://api.h.miguan.in/game/myCenter";
            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "GET";

            wbRequest.Accept = "application/json, text/plain, */*";
            wbRequest.Headers.Add("Origin", "http://h.miguan.in");
            wbRequest.Headers.Add("accessToken", token);
            wbRequest.Headers.Add("Cookie", $"token={token}; _ga=GA1.2.688806701.1811704586; _gid=GA1.8.177683714.1664296938; _gat=1");
            wbRequest.ContentType = "application/x-www-form-urlencoded";
            wbRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36";
            wbRequest.Referer = $"http://h.miguan.in/mine";

            HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
            using (Stream responseStream = wbResponse.GetResponseStream())
            {
                using (StreamReader sReader = new StreamReader(responseStream))
                {
                    result = sReader.ReadToEnd();
                }
            }
            RequestResultDto<MiguanUserInfoDto> output = JsonHelper.JsonToObject<RequestResultDto<MiguanUserInfoDto>>(result);
            if (!output.Success)
                throw new Exception(output.Msg);
            return output.Result;
        }

        public List<MonkeyInfoDto> GetMonkeysFromMarket(string token,int page,int gen=-1,int orderby=1,int sort=0)
        {
            string result = string.Empty;
            string url = $"http://api.h.miguan.in/game/homePage";

            string param = $"orderBy={orderby}&sort={sort}&status=1&current={page}&id=&gen={(gen==-1?"":gen+"")}";
            byte[] bs = Encoding.ASCII.GetBytes(param);

            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "Post";

            wbRequest.Headers.Add("Origin", "http://h.miguan.in");
            wbRequest.Headers.Add("accessToken", token);
            wbRequest.Headers.Add("Cookie", $"token={token}; _ga=GA1.2.588206501.1511004286; _gid=GA1.2.195683714.1514296938; _gat=1");
            wbRequest.ContentType = "application/x-www-form-urlencoded";
            wbRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36";
            wbRequest.Referer = "http://h.miguan.in/market";

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
            RequestResultDto<RequestListMonkeysDto> output = JsonHelper.JsonToObject<RequestResultDto<RequestListMonkeysDto>>(result);
            if (!output.Success)
                throw new Exception(output.Msg);
            return output.Result.records;
        }


        public RequestListMonkeys4AutoTradeDto<MyMonkey4FeedDto> GetMyMonkeys(string token,int page=1)
        {
            string result = string.Empty;
            string url = $"http://api.h.miguan.in/game/myMonkeyPage";

            string param = $"orderBy=1&sort=1&status=&current={page}";
            byte[] bs = Encoding.ASCII.GetBytes(param);

            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "Post";

            wbRequest.Headers.Add("Origin", "http://h.miguan.in");
            wbRequest.Headers.Add("accessToken", token);
            wbRequest.Headers.Add("Cookie", $"token={token}; _ga=GA1.2.588206501.1511004286; _gid=GA1.2.195683714.1514296938; _gat=1");
            wbRequest.ContentType = "application/x-www-form-urlencoded";
            wbRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36";
            wbRequest.Referer = "http://h.miguan.in/home";

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
            RequestResultDto<RequestListMonkeys4AutoTradeDto<MyMonkey4FeedDto>> output = JsonHelper.JsonToObject<RequestResultDto<RequestListMonkeys4AutoTradeDto<MyMonkey4FeedDto>>>(result);
            if (!output.Success)
                throw new Exception(output.Msg);
            return output.Result;
        }


        public bool BuyMonkey(string token,MonkeyInfoDto monkey)
        {
            string result = string.Empty;
            string url = $"http://api.h.miguan.in/game/buyCheck/{monkey.tid}";
            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "GET";

            wbRequest.Headers.Add("Origin", "http://h.miguan.in");
            wbRequest.Headers.Add("accessToken", token);
            wbRequest.Headers.Add("Cookie", $"token={token}; _ga=GA1.2.588206501.1511004286; _gid=GA1.2.195683714.1514296938; _gat=1");

            wbRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36";
            wbRequest.Referer = $"http://h.miguan.in/monkey/{monkey.id}";

            HttpWebResponse wbResponse = (HttpWebResponse)wbRequest.GetResponse();
            using (Stream responseStream = wbResponse.GetResponseStream())
            {
                using (StreamReader sReader = new StreamReader(responseStream))
                {
                    result = sReader.ReadToEnd();
                }
            }
            RequestResultDto<object> output = JsonHelper.JsonToObject<RequestResultDto<object>>(result);
            if (!output.Success)
                throw new Exception(output.Msg);
            return output.Success;
        }

      
        public RequestListMonkeys4AutoTradeDto<MyMonkey4XiuLianDto> GetMyMonkeys4XiuLian(string token, int page = 1)
        {
            string result = string.Empty;
            string url = $"http://api.h.miguan.in/game/myMonkeyPage";

            string param = $"orderBy=1&sort=1&status=&current={page}";
            byte[] bs = Encoding.ASCII.GetBytes(param);

            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "Post";

            wbRequest.Headers.Add("Origin", "http://h.miguan.in");
            wbRequest.Headers.Add("accessToken", token);
            wbRequest.Headers.Add("Cookie", $"token={token}; _ga=GA1.2.588206501.1511004286; _gid=GA1.2.195683714.1514296938; _gat=1");
            wbRequest.ContentType = "application/x-www-form-urlencoded";
            wbRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36";
            wbRequest.Referer = "http://h.miguan.in/home";

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
            RequestResultDto<RequestListMonkeys4AutoTradeDto<MyMonkey4XiuLianDto>> output = JsonHelper.JsonToObject<RequestResultDto<RequestListMonkeys4AutoTradeDto<MyMonkey4XiuLianDto>>>(result);
            if (!output.Success)
                throw new Exception(output.Msg);
            return output.Result;
        }

        public RequestListMonkeys4AutoTradeDto<StudyRecord> GetStudyRecords(string token, int page = 1)
        {
            string result = string.Empty;
            string url = $"http://api.h.miguan.in/game/studyRecordPage";

            string param = $"current={page}";
            byte[] bs = Encoding.ASCII.GetBytes(param);

            HttpWebRequest wbRequest = (HttpWebRequest)WebRequest.Create(url);
            wbRequest.Method = "Post";

            wbRequest.Headers.Add("Origin", "http://h.miguan.in");
            wbRequest.Headers.Add("accessToken", token);
            wbRequest.Headers.Add("Cookie", $"token={token}; _ga=GA1.2.588206501.1511004286; _gid=GA1.2.195683714.1514296938; _gat=1");
            wbRequest.ContentType = "application/x-www-form-urlencoded";
            wbRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36";
            wbRequest.Referer = "http://h.miguan.in/gold";

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
            RequestResultDto<RequestListMonkeys4AutoTradeDto<StudyRecord>> output = JsonHelper.JsonToObject<RequestResultDto<RequestListMonkeys4AutoTradeDto<StudyRecord>>>(result);
            if (!output.Success)
                throw new Exception(output.Msg);
            return output.Result;
        }
    }
}
