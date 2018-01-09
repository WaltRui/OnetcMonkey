using OnetcMonkeyComputer.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.Services.Dtos
{
    public class FeedPageDto
    {
        public List<FeedDto> records { get; set; }

        public double Coin_today { get; set; }
        public void TodayFeed()
        {
            var day = DateTime.Now.ToString("yyyyMMdd");
            var coin =records.Where(w => w.day == day)
                .Sum(s => s.coin);
            Coin_today= coin;
        }
    }

    public class FeedDto
    {
        public double addBear { get; set; }
        public double addGrow { get; set; }
        public double addMoney { get; set; }

        /// <summary>
        /// 花费的玩客币
        /// </summary>
        public double coin { get; set; }
        public long createTime { get; set; }

        public DateTime FeedTime
        {
            get
            {
                return DateTimeConverterTool.ConvertStringToDateTime(createTime.ToString());
            }
        }

        /// <summary>
        /// 当前体重
        /// </summary>
        public double currentWeight { get; set; }

        /// <summary>
        /// 字符串日期 如：20171227
        /// </summary>
        public string day { get; set; }

        public string hash { get; set; }

        /// <summary>
        /// 喂养ID
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 猴子ID
        /// </summary>
        public long monkeyId { get; set; }

        public long userId { get; set; }

        /// <summary>
        /// 喂食增加的体重
        /// </summary>
        public double weight { get; set; }


    }
}
