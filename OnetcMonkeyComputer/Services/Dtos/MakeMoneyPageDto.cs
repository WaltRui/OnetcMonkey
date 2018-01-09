using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.Dtos
{
    public class MakeMoneyPageDto
    {
        public List<MakeMoneyDto> records { get; set; }

    }

    public class MakeMoneyDto
    {
        public double coin { get; set; }

        public string day { get; set; }

        public double? feedDayNum { get; set; }

        public int generation { get; set; }

        public double makeMoney { get; set; }

        public double makeMoneyScore { get; set; }

        public double weight { get; set; }

        public long userId { get; set; }


    }
}
