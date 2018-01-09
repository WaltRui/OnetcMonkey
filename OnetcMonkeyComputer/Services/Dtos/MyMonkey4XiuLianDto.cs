using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.Dtos
{
    public class MyMonkey4XiuLianDto
    {
        public long Id { get; set; }

        public int Generation { get; set; }

        public double GrowIng { get; set; }
        public double Bear { get; set; }
        public double Grow { get; set; }
        public double MakeMoney { get; set; }

        public double Weight { get; set; }

        public double XiuLianToday { get; set; }

        public List<double> FeedList { get; set; }

        public string MinProperty
        {
            get
            {
                if (Bear < Grow && Bear < MakeMoney)
                    return "生育";
                if(Grow<Bear && Grow<MakeMoney)
                    return "成长";
                if (MakeMoney < Bear && MakeMoney < Grow)
                    return "掘金";
                if(Bear==Grow && Bear<MakeMoney)
                    return "生育、成长";
                if (Bear == MakeMoney && Bear < Grow)
                    return "生育、掘金";
                if (MakeMoney == Grow && MakeMoney < Bear)
                    return "掘金、成长";
                if(MakeMoney == Grow && MakeMoney == Bear)
                    return "生育、成长、掘金";
                return "未知";
            }
        }
        public double MinPropertyValue
        {
            get
            {
                var min = Math.Min(Bear, Grow);
                min = Math.Min(min, MakeMoney);
                return min;
            }
        }

        public bool IsAuto
        {
            get
            {
                return FeedList != null && FeedList.Count > 0;
            }
        }

        public string Des { get; set; }

        public double Time
        {
            get
            {
                if (FeedList == null)
                    return 0;
                return FeedList.Count;
            }
        }

        public double FeeSum
        {
            get
            {
                if (FeedList == null)
                    return 0;
                return FeedList.Count * 0.01;
            }
        }

        public string FeedSum
        {
            get
            {
                if (FeedList == null)
                    return "0";
                return FeedList.Sum().ToString("f6");
            }
        }

        public string Cost
        {
            get
            {
                if (FeedList == null)
                    return "0";
                return (FeedList.Sum() + FeeSum).ToString("f6");
            }
        }
    }
}
