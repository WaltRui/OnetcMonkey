using OnetcMonkeyComputer.Config;
using OnetcMonkeyComputer.Eggs;
using OnetcMonkeyComputer.Services;
using OnetcMonkeyComputer.Services.RequestDtos;
using OnetcMonkeyComputer.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace OnetcMonkeyComputer.Forms.MonkeyDetail
{
    public partial class MonkeyDetailForm : Form
    {
        private IConfigService _configService;
        private AppConfig config;
        private IMonkeyService _monkeyService;
        public MonkeyDetailForm()
        {
            InitializeComponent();

            _configService = new ConfigService();
            var config =_configService.ReadConfig();
            _monkeyService = new MonkeyService(config.BaseApiUrl, config.BaseUrl);
        }

        private void button_get_detail_Click(object sender, EventArgs e)
        {
            numericUpDown_monkeyId.Enabled = button_get_detail.Enabled = false;
            var id = (long)numericUpDown_monkeyId.Value;
            try
            {
                var detail = _monkeyService.GetMonkeyDetail(config.Token, id);
                detail.feedPage.TodayFeed();

                var toushi = detail.monkey.growIng!=null && detail.monkey.growIng > 0 ? (double)detail.monkey.growIng : detail.monkey.growLimit??5;
                detail.monkey.SetJueJinFenShu(toushi);
                detail.monkey.SetBearCd();
                var monkey = detail.monkey;

                webKitBrowser1.Navigate(monkey.facade);
                //webBrowser1.Navigate(monkey.facade);

                label_generation_weight.Text = $"{monkey.generation} 代 - {monkey.weight} kg";
                label_grow.Text = $"成长：{monkey.grow}";
                label_bear.Text = $"生育：{monkey.bear}" + $"    已完成{monkey.bearNum}次生育";
                label_makemoney.Text = $"掘金：{monkey.makeMoney}";

                var nextBearDate = DateTimeConverterTool.ConvertStringToDateTime(monkey.nextBearDate.ToString());
                TimeSpan ts = nextBearDate.Subtract(DateTime.Now);
                var nextbear = ts.TotalMinutes > 0 ? (ts.Days + "天" + ts.Hours + "小时" + ts.Minutes + "分钟后") : ("准备就绪");
                label_generationcoeff.Text = $"{monkey.generation}代系数为：{monkey.GenerationCoef}";

                label_cur_bearcd.Text = $"最近一次生育时间：{nextbear}";
                label_bearcd.Text = $"下次生育冷却时间：{monkey.NextBearCD}分钟";
                label_juejinfenshu.Text = $"掘金分数预估：{monkey.JueJinFenShu}";
                var todaycoin = ComputeCoin(monkey.JueJinFenShu);
                label_money.Text = $"今日收益预估：{todaycoin.ToString("f6")} wkc";
                DrawRadarChart(detail);
                ShowEggs(detail);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("未登录"))
                    MessageBox.Show("请前往  帮助---设置   进行token配置！");
                else
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                numericUpDown_monkeyId.Enabled = button_get_detail.Enabled = true;
            }

        }

        private void ShowEggs(RequestMonkeyWithUserDetailDto detail)
        {
            label7.Text = "";
            var eggs = AvatarEggs.Eggs;
            var indexs = eggs.Select(w=>w.Index).ToList().Distinct().ToList();
            
            foreach (var e in eggs)
            {
                if(detail.monkey.hash[e.Index].ToString()==e.Value)
                {
                    var show = eggs.Where(w=>w.Index == e.Index && w.Value==e.Value).ToList();
                    var count = show.Count;
                    var r_s = new Random().Next(0, count);

                    int ran = DateTime.Now.Millisecond;
                    if (ran > 500)
                    {
                        var showtext = show[r_s].Text;
                        label7.Text = showtext;
                    }
                    return;
                }

            }
             
        }

        private void DrawRadarChart(RequestMonkeyWithUserDetailDto monkey)
        {
            monkey.ComputeRadarData();
            var pieUrl = $"http://h.app.hnbc.info/charts/monkey_radar.html?bear={monkey.Radar_Bear}&juejin={monkey.Radar_JueJin}&luck={monkey.Radar_Luck}&grow={monkey.Radar_Grow}&weight={monkey.Radar_Weight}&dna={monkey.Radar_DNA}";
            webKitBrowser_radar.Navigate(pieUrl);

            DrawLineJueJin(monkey,zedGraphControl_juejin, DrawType.JueJin);
            DrawLineJueJin(monkey, zedGraphControl_coin, DrawType.Coin);
        }

        private void DrawLineJueJin(RequestMonkeyWithUserDetailDto monkey, ZedGraphControl zgc, DrawType type)
        {
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();

            GraphPane myPane = zgc.GraphPane;

            //设置图标标题和x、y轴标题
            if(type== DrawType.JueJin)
                myPane.Title.Text = "每日掘金分数走势";
            else
                myPane.Title.Text = "每日掘金收益走势";
            myPane.XAxis.Title.IsVisible = false;
            myPane.YAxis.Title.IsVisible = false;

            //更改标题的字体
            FontSpec myFont = new FontSpec("宋体", 20, Color.Gray, false, false, false);
            myPane.Title.FontSpec = myFont;
            myPane.XAxis.Title.FontSpec = myFont;
            myPane.YAxis.Title.FontSpec = myFont;
            myPane.Legend.FontSpec = myFont;

            var list = monkey.makeMoneyPage.records;
            list = list.OrderBy(o=>o.day).ToList();
            var count = list.Count;
            string[] labels = new string[count];

            PointPairList list1 = new PointPairList();
            for (int i = 0; i < count; i++)
            {
                var dto = list[i];
                try
                {
                    var showx = dto.day.Substring(0, 4) + "-" + dto.day.Substring(4, 2) + "-" + dto.day.Substring(6, 2);
                    labels[i] = showx;
                }
                catch
                {
                    labels[i] = dto.day;
                }

                double x = i;
                double y1 = dto.makeMoneyScore;
                if (type == DrawType.Coin)
                    y1 = dto.coin;
                list1.Add(x, y1);
            }

            // 用list1生产一条曲线
            LineItem myCurve = myPane.AddCurve(type== DrawType.JueJin?"掘金分数":"掘金收益", list1, Color.Red, SymbolType.Circle);            

            //填充图表颜色
            myPane.Fill = new Fill(Color.White, Color.FromArgb(200, 200, 255), 45.0f);

            myPane.XAxis.Scale.TextLabels = labels; //X轴文本取值
            myPane.XAxis.Type = AxisType.Text;   //X轴类型

            //画到zedGraphControl1控件中，此句必加
            zgc.AxisChange();
            //重绘控件
            Refresh();
        }

        private void MonkeyDetailForm_Load(object sender, EventArgs e)
        {
            config = _configService.ReadConfig();
        }


        private double ComputeCoin(double makeMoneyScore)
        {
            double coin = 0;
            var overviews = _configService.ReadOverViewData();
            overviews = overviews.OrderByDescending(o=>o.Date).ToList();
            if(overviews.Count>=3)
            {
                var a2 = overviews[2].AllMakeMoneyScore / overviews[2].AllMakeMoney;
                var a1 = overviews[1].AllMakeMoneyScore / overviews[1].AllMakeMoney;
                var a0 = overviews[0].AllMakeMoneyScore / overviews[0].AllMakeMoney;

                var a = ((a1 - a2) + (a0 - a1)) / 2;

                var todayNandu = a0 + a;

                coin = makeMoneyScore / todayNandu;
            }
            else if(overviews.Count>0)
            {
                var a0 = overviews[0].AllMakeMoneyScore / overviews[0].AllMakeMoney;
                coin = makeMoneyScore / a0;
            }
            return coin;

        }
    }

    public enum DrawType
    {
        JueJin,
        Coin
    }
}
