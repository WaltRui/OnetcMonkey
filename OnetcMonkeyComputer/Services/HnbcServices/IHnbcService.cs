using OnetcMonkeyComputer.Services.HnbcServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.HnbcServices
{
    public interface IHnbcService
    {
        List<OverViewDataDto> GetOverViews(string day);

        List<NewsDto> GetNews();
    }
}
