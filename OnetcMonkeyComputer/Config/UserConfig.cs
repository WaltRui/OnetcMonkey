using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Config
{
    public class UserConfig
    {
        public bool IsSearchEnable { get; set; }
        
        public bool Disabled { get; set; }

        public string Wallet { get; set; }

        public int RandomValue { get; set; }
    }
}
