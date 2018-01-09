using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer
{
    public static class AppConst
    {
        public static string ServerBaseUrl = "http://api.app.hnbc.info/v1/apps/wcmonkey";

        public static string GetOverViewDataUrl = ServerBaseUrl+ "/markets";

        public static string GetNewsUrl = ServerBaseUrl + "/news";
        
    }
}
