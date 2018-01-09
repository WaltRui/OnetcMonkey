using OnetcMonkeyComputer.Tools.Encrypt;
using OnetcMonkeyEncrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.AppServices.Dtos
{
    public class LoginInput
    {
        public string Sign { get; set; }

        public void EnCode(string wallet,string name)
        {
            Sign = HnbcUserSignService.GetSign(wallet, name);           
        }
    }
}
