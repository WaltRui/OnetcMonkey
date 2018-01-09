using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.Dtos
{
    public class MyMonkey4FeedDto
    {

        public long Id { get; set; }

        public int Generation { get; set; }

        public double GrowIng { get; set; }

        public double Weight { get; set; }

        public List<double> FeedList { get; set; }

        public bool IsAuto { get {
                return FeedList != null && FeedList.Count > 0;
            } }

        public string Des { get; set; }

        public double FeeSum
        {
            get {
                if (FeedList == null)
                    return 0;
                return FeedList.Count*0.01;
            }
        }

        public string FeedSum { get {
                if (FeedList == null)
                    return "0";
                return FeedList.Sum().ToString("f6");
            } }
        
        public string Cost { get {
                if (FeedList == null)
                    return "0";
                return (FeedList.Sum() + FeeSum).ToString("f6");
            } }
    }
}
