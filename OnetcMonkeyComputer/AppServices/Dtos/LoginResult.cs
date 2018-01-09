using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.AppServices.Dtos
{
    public class LoginResult
    {
        public string accessToken { get; set; }

        public string userConfig { get; set; }
    }
}
