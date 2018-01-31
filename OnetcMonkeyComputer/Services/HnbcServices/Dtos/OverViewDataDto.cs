using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.HnbcServices.Dtos
{
    public class OverViewDataDto
    {
        public string ServerTag { get; set; }

        public string Date { get; set; }

        public double Game { get; set; }
        public double GamePara { get; set; }

        public double Trade { get; set; }
        public double TradePara { get; set; }

        public double Bear { get; set; }
        public double BearPara { get; set; }

        public double Feed { get; set; }
        public double FeedPara { get; set; }

        public double Sale { get; set; }
        public double SalePara { get; set; }

        public double Other { get; set; }
        public double OtherPara { get; set; }

        public string Description { get; set; }

        public double AllMakeMoney { get; set; }

        public double AllMakeMoneyScore { get; set; }

        public DateTime CreationTime { get; set; }
    }
     
}
