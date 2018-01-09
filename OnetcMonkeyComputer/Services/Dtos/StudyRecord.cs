using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.Dtos
{
    public class StudyRecord
    {
        public double Coin { get; set; }

        public long MonkeyId { get; set; }

        public long CreateTime { get; set; }

        public string OpenDay { get; set; }

        public double MonkeyBear { get; set; }
        public double MonkeyGrow { get; set; }
        public double MonkeyMoney { get; set; }


    }
}
