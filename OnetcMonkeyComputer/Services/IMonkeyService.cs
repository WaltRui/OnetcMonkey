using OnetcMonkeyComputer.Services.Dtos;
using OnetcMonkeyComputer.Services.RequestDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services
{
    public interface IMonkeyService
    {
        RequestMonkeyWithUserDetailDto GetMonkeyDetail(string token, long id);

        List<MonkeyInfoDto> GetMonkeysFromMarket(string token, int page, int gen = -1,int orderby=1,int sort=0);

        List<MonkeyInfoDto> FilterMonkeysFromMarket(FilterMonkeysFromMarketInput input);

        bool BuyMonkey(string token, MonkeyInfoDto monkey);

        MiguanUserInfoDto GetUserInfo(string token);

        RequestListMonkeys4AutoTradeDto<MyMonkey4FeedDto> GetMyMonkeys(string token, int page = 1);


        RequestListMonkeys4AutoTradeDto<MyMonkey4XiuLianDto> GetMyMonkeys4XiuLian(string token, int page = 1);

        RequestListMonkeys4AutoTradeDto<StudyRecord> GetStudyRecords(string token, int page = 1);

        BalanceFeedResult BalanceFeed(string token, long monkeyId, double coin);
    }
}
