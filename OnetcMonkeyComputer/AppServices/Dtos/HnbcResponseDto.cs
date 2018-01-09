using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.AppServices.Dtos
{
    public class HnbcResponseDto<T>
    {
        public T Result { get; set; }

        public bool Success { get; set; }

        public string Error { get; set; }

    }
}
