using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.Dtos
{
    public class MonkeyInfoDto
    {
        private const double MaxToushi = 5;

        public long id { get; set; }

        public int generation { get; set; }

        public double weight { get; set; }

        public double grow { get; set; }

        public double? growIng { get; set; }

        public double? growLimit { get; set; }

        public double bear { get; set; }

        public double makeMoney { get; set; }

        public int bearNum { get; set; }

        public double price { get; set; }

        public string facade { get; set; }

        public string hash { get; set; }

        public long tid { get; set; }

        public long nextBearDate { get; set; }

        public string initDes { get; set; }

        public double JueJinFenShu { get; set; }

        public int NextBearCD { get; set; }

        public double GenerationCoef { get; set; }

        public void SetJueJinFenShu(double toushi = 0)
        {
            //有效投食
            if (toushi <= 0)
                toushi = MaxToushi;
            GenerationCoef = ComputeGenerationCoefficient(generation);
            //小猴掘金分数=体重*掘金属性值*当日有效投食金额/代系数
            var _weight = weight > 0 ? weight : toushi * grow;
            var juejinfenshu = _weight * makeMoney * toushi / GenerationCoef;
            JueJinFenShu = juejinfenshu;
        }

        private const int StandardBearCd = 30;
        private const double BearCoefficient = 0.42;
        public void SetBearCd()
        {
            //实际生育冷却时间 = 标准生育时间 *（1 + 生育系数）^（已生育次数）*代系数 / (1 + 生育值 ^ 2 / 10)

            GenerationCoef = ComputeGenerationCoefficient(generation);
            var cd = StandardBearCd * Math.Pow(1 + BearCoefficient, bearNum) * GenerationCoef / (1 + Math.Pow(bear, 2) / 10);

            this.NextBearCD = (int)Math.Round(cd);
        }
        
        private const double DecreaseCoefficient = 0.168;
        private double ComputeGenerationCoefficient(int generation)
        {
            //目前的标准代数损益系数为0.168，算法为：x代系数 =（1 + 标准系数）^ x，如0代为1，1代就是1.168，2代为1.364。

            return Math.Pow(1 + DecreaseCoefficient, generation);
        }


    }
}
