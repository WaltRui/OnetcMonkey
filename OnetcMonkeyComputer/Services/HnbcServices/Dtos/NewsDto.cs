using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.HnbcServices.Dtos
{
    public class NewsDto
    {
        public string Title { get; set; }

        public string Source { get; set; }

        public string Abstract { get; set; }

        public string Url { get; set; }

        public string PostTime { get; set; }
    }
}
