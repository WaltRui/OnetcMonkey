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

        public double Grow { get; set; }

        public double Weight { get; set; }

        public double MakeMoney { get; set; }

        public double YesterdayCoin { get; set; }

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



        private const double MaxToushi = 5;
        public double JueJinFenShu { get; set; }
        
        public double GenerationCoef { get; set; }

        public void SetJueJinFenShu(double toushi = 0)
        {
            //有效投食
            if (toushi <= 0)
                toushi = MaxToushi;
            GenerationCoef = ComputeGenerationCoefficient(Generation);
            var addweight = Grow * toushi*0.8125;
            //小猴掘金分数=体重*掘金属性值*当日有效投食金额/代系数
            var _weight = Weight > 0 ? Weight + addweight : toushi * Grow;
            
            var juejinfenshu = _weight * MakeMoney * toushi / GenerationCoef;
            JueJinFenShu = juejinfenshu;
        }
         
        private const double DecreaseCoefficient = 0.168;
        private double ComputeGenerationCoefficient(int generation)
        {
            //目前的标准代数损益系数为0.168，算法为：x代系数 =（1 + 标准系数）^ x，如0代为1，1代就是1.168，2代为1.364。

            return Math.Pow(1 + DecreaseCoefficient, generation);
        }

    }
}
