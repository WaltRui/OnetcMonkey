using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.Dtos
{
    public class FilterMonkeysFromMarketInput
    {
        
        public string token { get; set; }
        
        public int orderBy { get; set; }

        public int sort { get; set; }

        public int current { get; set; }


        public int startGen { get; set; }

        public int endGen { get; set; }


        public double startGrow { get; set; }

        public double endGrow { get; set; }


        public double startBear { get; set; }

        public double endBear { get; set; }


        public double startMakeMoney { get; set; }

        public double endMakeMoney { get; set; }


        public int startBearNum { get; set; }

        public int endBearNum { get; set; }


        public double startWeight { get; set; }

        public double endWeight { get; set; }

    }
}
