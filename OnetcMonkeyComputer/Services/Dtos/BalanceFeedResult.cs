using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.Dtos
{
    public class BalanceFeedResult
    {
        public double? addBear { get; set; }
        public double? addGrow { get; set; }
        public double? addMoney { get; set; }

        public string hash { get; set; }
    }
}
