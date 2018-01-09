using OnetcMonkeyComputer.Services.Dtos;
using OnetcMonkeyComputer.Tools;
using System.Linq;

namespace OnetcMonkeyComputer.Services.RequestDtos
{
    public class RequestMonkeyWithUserDetailDto
    {
        public MonkeyInfoDto monkey { get; set; }

        public FeedPageDto feedPage { get; set; }

        public MakeMoneyPageDto makeMoneyPage { get; set; }
        
        #region Radar Chart Data
        public int Radar_Luck { get; set; }

        public int Radar_JueJin { get; set; }

        public int Radar_Weight { get; set; }

        public int Radar_Grow { get; set; }

        public int Radar_DNA { get; set; }

        public int Radar_Bear { get; set; }

        public void ComputeRadarData()
        {
            //Radar_Luck
            var baojiTime = feedPage.records
                .Count(w => w.addBear > 0 || w.addGrow > 0 || w.addMoney > 0);
            var feedTime = feedPage.records.Count;
            var baojivalue = 0;
            if (feedTime > 0)
                baojivalue = (int)(100.0 * baojiTime / feedTime);

            var dnavalue = StringHelper.GetNumberIntSum(monkey.initDes);
            Radar_Luck = baojivalue == 0 ? 30 : baojivalue + dnavalue;
            if (Radar_Luck > 100)
                Radar_Luck = 100;
            if (Radar_Luck < 10)
                Radar_Luck = 10;

            //Radar_JueJin
            if (makeMoneyPage.records.Count>0)
            {
               
                Radar_JueJin =(int)(makeMoneyPage.records[0].coin*3+15);
            }
            else
            {
                if(monkey.JueJinFenShu<=0)
                    monkey.SetJueJinFenShu();
                Radar_JueJin = 30;
            }
            Radar_JueJin = Radar_JueJin > 100 ? 100:Radar_JueJin;

            //Radar_Weight
            Radar_Weight = (int)monkey.weight;
            Radar_Weight = Radar_Weight > 100 ? 100 : Radar_Weight;

            //Radar_Grow

            Radar_Grow = (int)(100 - 60 / monkey.grow);
            Radar_Grow = Radar_Grow > 100 ? 100 : (Radar_Grow>0? Radar_Grow:20);

            //Radar_DNA
            if (monkey.GenerationCoef <= 0)
                monkey.SetBearCd();
            if(monkey.GenerationCoef>0)
                Radar_DNA =(int)(dnavalue + 80/monkey.GenerationCoef);
            Radar_DNA = Radar_DNA > 100 ? 100 : (Radar_DNA > 0 ? Radar_DNA : 20);

            ///RadarBear
            if (monkey.NextBearCD <= 0)
                monkey.SetBearCd();
            Radar_Bear = 100 - 40 * monkey.NextBearCD / 1000;
            if (Radar_Bear > 100)
                Radar_Bear = 100;
            if (Radar_Bear < 10)
                Radar_Bear = 10;
            
        }



        #endregion

    }
}
