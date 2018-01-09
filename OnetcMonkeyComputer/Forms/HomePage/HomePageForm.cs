using OnetcMonkeyComputer.Config;
using OnetcMonkeyComputer.Services.HnbcServices;
using OnetcMonkeyComputer.Services.HnbcServices.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebKit.Interop;
using ZedGraph;

namespace OnetcMonkeyComputer.Forms.HomePage
{
    public partial class HomePageForm : Form
    {
        public delegate void LoadData();

        private IHnbcService _hnbcService;
        private IConfigService _configService;
        private OverViewDataDto newestData;
        public HomePageForm()
        {
            InitializeComponent();
            _hnbcService = new HnbcService();
            _configService = new ConfigService();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            LoadOvData();
        }

        private void LoadOvData()
        {
            this.Invoke(new LoadData(LoadOverViewData));
        }

        private void ShowOverViewData(OverViewDataDto newestData, List<OverViewDataDto> list)
        {
            if (newestData == null)
                return;
            label_day.Text = newestData.Date.Substring(0, 4) + "-" + newestData.Date.Substring(4, 2) + "-" + newestData.Date.Substring(6, 2);
            label_trade.Text = newestData.Trade.ToString("f4");
            label_bear.Text = newestData.Bear.ToString("f4");
            label_feed.Text = newestData.Feed.ToString("f4");
            label_game.Text = newestData.Game.ToString("f4");
            label_pai.Text = newestData.Sale.ToString("f4");
            label_other.Text = newestData.Other.ToString("f4");

            label_allmomey.Text = newestData.AllMakeMoney.ToString("f4");
            label_allScore.Text = newestData.AllMakeMoneyScore.ToString("f4");
            label_description.Text = newestData.Description;

            var trad = (int)newestData.Trade <= 0 ? "" : $"trade={(int)(newestData.Trade * newestData.TradePara)}&";
            var bear = (int)newestData.Bear <= 0 ? "" : $"bear={ (int)(newestData.Bear * newestData.BearPara)}&";
            var feed = (int)newestData.Feed <= 0 ? "" : $"feed={(int)(newestData.Feed * newestData.FeedPara)}&";
            var game = (int)newestData.Game <= 0 ? "" : $"game={((int)(newestData.Game * newestData.GamePara))}&";
            var sale = (int)newestData.Sale <= 0 ? "" : $"sale={(int)(newestData.Sale * newestData.SalePara)}";
            var other = (int)newestData.Other <= 0 ? "" : $"other={(int)(newestData.Other * newestData.OtherPara)}";

            var pieUrl = $"http://h.app.hnbc.info/charts/makemoney_pie.html?{trad}{bear}{feed}{game}{sale}{other}";
            webKitBrowser1.Navigate(pieUrl);

            CreatePane(zedGraphControl1, list);
            CreateChart(zedGraphControl2, list);
            FillWebBrowser();
        }

        private void LoadOverViewData()
        {
            var overviewData = _configService.ReadOverViewData();

            newestData = overviewData.OrderByDescending(o => o.Date)
                .FirstOrDefault();
            var day = newestData?.Date;
            var yesterday = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
            if (day != null && day == yesterday)
            {
                overviewData = overviewData.OrderByDescending(o => o.Date).ToList();
                newestData = overviewData.OrderByDescending(o => o.Date)
                    .FirstOrDefault();
                ShowOverViewData(newestData, overviewData);
                return;
            }
            var newdata = _hnbcService.GetOverViews("20171224");
            overviewData = newdata;
            //foreach (var d in newdata)
            //{
            //    var isexist = overviewData.Where(w => w.Date == d.Date).Count();
            //    if (isexist > 0)
            //    {
            //        _configService.SaveOverViewData(overviewData);
            //        overviewData = overviewData.OrderByDescending(o => o.Date).ToList();
            //        newestData = overviewData.OrderByDescending(o => o.Date)
            //            .FirstOrDefault();
            //        ShowOverViewData(newestData, overviewData);
            //        return;
            //    }
            //    overviewData.Add(d);
            //}
            overviewData = overviewData.OrderByDescending(o => o.Date).ToList();
            newestData = overviewData.OrderByDescending(o => o.Date)
                .FirstOrDefault();
            _configService.SaveOverViewData(overviewData);
            ShowOverViewData(newestData, overviewData);
        }


        #region 图表
        public void CreatePane(ZedGraphControl zgc, List<OverViewDataDto> list)
        {
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();

            GraphPane myPane = zgc.GraphPane;

            //设置图标标题和x、y轴标题
            myPane.Title.Text = "掘金池总额变化";
            myPane.XAxis.Title.IsVisible = false;
            myPane.YAxis.Title.IsVisible = false;

            //更改标题的字体
            FontSpec myFont = new FontSpec("宋体", 20, Color.Gray, false, false, false);
            myPane.Title.FontSpec = myFont;
            myPane.XAxis.Title.FontSpec = myFont;
            myPane.YAxis.Title.FontSpec = myFont;
            myPane.Legend.FontSpec = myFont;

            list = list.OrderBy(o => o.Date).ToList();

            string[] labels = new string[list.Count];

            PointPairList list1 = new PointPairList();
            PointPairList list2 = new PointPairList();
            for (int i = 0; i < list.Count; i++)
            {
                var dto = list[i];
                try
                {
                    var showx = dto.Date.Substring(0, 4) + "-" + dto.Date.Substring(4, 2) + "-" + dto.Date.Substring(6, 2);
                    labels[i] = showx;
                }
                catch {
                    labels[i] = dto.Date;
                }

                double x = i;
                double y1 = dto.AllMakeMoney;
                double y2 = dto.AllMakeMoneyScore;
                list1.Add(x, y1);
                list2.Add(x, y2);
            }

            // 用list1生产一条曲线
            LineItem myCurve = myPane.AddCurve("掘金池总额", list1, Color.Red, SymbolType.Circle);

            LineItem myCurve2 = myPane.AddCurve("掘金分", list2, Color.Blue, SymbolType.Circle);

            //填充图表颜色
            myPane.Fill = new Fill(Color.White, Color.FromArgb(200, 200, 255), 45.0f);

            myPane.XAxis.Scale.TextLabels = labels; //X轴文本取值
            myPane.XAxis.Type = AxisType.Text;   //X轴类型

            //画到zedGraphControl1控件中，此句必加
            zgc.AxisChange();

            //重绘控件
            Refresh();
        }




        public void CreateChart(ZedGraphControl zgc, List<OverViewDataDto> list)
        {
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();

            GraphPane myPane = zgc.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = "掘金难度";
            myPane.XAxis.Title.IsVisible = false;
            myPane.YAxis.Title.IsVisible = false;

            FontSpec myFont = new FontSpec("宋体", 20, Color.Gray, false, false, false);
            myPane.Title.FontSpec = myFont;
            myPane.XAxis.Title.FontSpec = myFont;
            myPane.YAxis.Title.FontSpec = myFont;
            myPane.Legend.FontSpec = myFont;

            list = list.OrderBy(o => o.Date).ToList();

            string[] labels = new string[list.Count];

            PointPairList list1 = new PointPairList();
            for (int i = 0; i < list.Count; i++)
            {
                var dto = list[i];

                try
                {
                    var showx = dto.Date.Substring(0, 4) + "-" + dto.Date.Substring(4, 2) + "-" + dto.Date.Substring(6, 2);
                    labels[i] = showx;
                }
                catch
                {
                    labels[i] = dto.Date;
                }
                double x = i;
                double y1 = dto.AllMakeMoneyScore / dto.AllMakeMoney;
                list1.Add(x, y1);
            }

            // Generate a red curve with diamond symbols, and "Velocity" in the legend
            LineItem myCurve = myPane.AddCurve("难度",
               list1, Color.Red, SymbolType.Diamond);
            // Fill the symbols with white
            myCurve.Symbol.Fill = new Fill(Color.White);

            // Show the x axis grid
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.Scale.TextLabels = labels; //X轴文本取值
            myPane.XAxis.Type = AxisType.Text;   //X轴类型

            // Make the Y axis scale red
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            myPane.YAxis.Title.FontSpec.FontColor = Color.Red;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis

            // Align the Y axis labels so they are flush to the axis
            myPane.YAxis.Scale.Align = AlignP.Inside;


            // Fill the axis background with a gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);

            zgc.AxisChange();
        }


        #endregion


        private void FillWebBrowser()
        {

            var news = _hnbcService.GetNews();
            news = news.OrderByDescending(o => o.PostTime).ToList();
            var news_html = "";
            foreach (var n in news)
            {
                news_html += $"<li><a href='{n.Url}' target='_blank'>【{n.Source}】{n.Title}</a><span>{n.PostTime}</span></li>";

            }


            string html = @"<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>
                <html xmlns='http://www.w3.org/1999/xhtml'>
                <head>
                <style type='text/css'>
                *{ margin:0; padding:0; font-size:12px; font-family:'新宋体';}
                ol{ background:url(/imagesforcode/201209/dots.jpg) no-repeat left -2px;}
                li{position:relative; padding-left:20px;  height:20px; overflow:hidden; line-height:20px; width:300px; list-style:none;padding-right:60px;}
                li a{ display:inline-block; text-decoration:none; color:#000;}
                li a:hover{ text-decoration:underline;}
                li span{ position:absolute; padding-left:5px;  color:#AAA;}
                </style>
                </head>
                <body style='background:#F8F8F8;'>
                <ol>"
                + news_html
                + @"
                </ol>
                </body>
                </html>";

            webKitBrowser_officail.DocumentText = html;

        }

        #region 解决webketBrowser无法打开新窗口的问题
        private void webKitBrowser_officail_NewWindowCreated(object sender, WebKit.NewWindowCreatedEventArgs e)
        {
            e.WebKitBrowser.Navigating += new WebBrowserNavigatingEventHandler(WebKitBrowser_Navigating);
            this.Controls.Add(e.WebKitBrowser);
        }
        private void WebKitBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            try
            {
                Process.Start(e.Url.ToString());
            }
            catch { }
        }
        #endregion
        
    }
}
