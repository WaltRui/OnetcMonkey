using OnetcMonkeyComputer.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.RequestDtos
{
    public class RequestListMonkeysDto
    {
        public List<MonkeyInfoDto> records { get; set; }
    }
}
