using OnetcMonkeyComputer.Services.HnbcServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Config
{
    public interface IConfigService
    {
        void Save(AppConfig config);

        AppConfig ReadConfig();

        List<OverViewDataDto> ReadOverViewData();

        void SaveOverViewData(List<OverViewDataDto> data);

        UserConfig GetUserConfig();

    }
}
