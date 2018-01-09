using OnetcMonkeyComputer.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.RequestDtos
{
    public class RequestListMonkeys4AutoTradeDto<T>
    {
        public List<T> records { get; set; }

        public int size { get; set; }

        public int total { get; set; }

    }
}
