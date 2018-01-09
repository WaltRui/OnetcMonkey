using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.RequestDtos
{
    public class RequestResultDto<T>
    {
        public int Code { get; set; }

        public string Msg { get; set; }

        public bool Success { get; set; }

        public T Result { get; set; }
    }
}
