using OnetcMonkeyComputer.AppServices;
using OnetcMonkeyComputer.Services;
using OnetcMonkeyComputer.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnetcMonkeyComputer
{
    public partial class MonkeyDetailForm : Form
    {
        private int appVersionCode=2;
        private IMonkeyService _monkeyService;
        private IAppService _appService;
        public MonkeyDetailForm()
        {
            InitializeComponent();

            _monkeyService = new MonkeyService();
            _appService = new AppService();
        }

        private void button_get_detail_Click(object sender, EventArgs e)
        {
            var token = textBox_token.Text;
            numericUpDown_monkeyId.Enabled = numericUpDown_toushi.Enabled = button_get_detail.Enabled = false;
            var id = (long)numericUpDown_monkeyId.Value;
            try
            {
                var detail = _monkeyService.GetMonkeyDetail(token,id);
                detail.feedPage.TodayFeed();

                var toushi = detail.feedPage.Coin_today > 0 ? detail.feedPage.Coin_today: (double)numericUpDown_toushi.Value;
                detail.monkey.SetJueJinFenShu(toushi);
                detail.monkey.SetBearCd();
                var monkey = detail.monkey;

                webBrowser1.Navigate(monkey.facade, "_self", null, $"Referer:http://h.miguan.in/monkey/{monkey.id}");
                //webBrowser1.Navigate(monkey.facade);

                label_generation_weight.Text = $"{monkey.generation} 代 - {monkey.weight} kg";
                label_grow.Text = $"成长：{monkey.grow}";
                label_bear.Text = $"生育：{monkey.bear}" + $"    已完成{monkey.bearNum}次生育";
                label_makemoney.Text = $"掘金：{monkey.makeMoney}";

                var nextBearDate = DateTimeConverterTool.ConvertStringToDateTime(monkey.nextBearDate.ToString());
                TimeSpan ts = nextBearDate.Subtract(DateTime.Now);
                var nextbear = ts.TotalMinutes > 0 ? (ts.Days+"天"+ts.Hours+"小时"+ts.Minutes + "分钟后") : ("准备就绪");
                label_generationcoeff.Text = $"{monkey.generation}代系数为：{monkey.GenerationCoef}";

                label_cur_bearcd.Text = $"最近一次生育时间：{nextbear}";
                label_bearcd.Text = $"下次生育冷却时间：{monkey.NextBearCD}分钟";
                label_juejinfenshu.Text = $"掘金分数预估：{monkey.JueJinFenShu}";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            numericUpDown_monkeyId.Enabled = numericUpDown_toushi.Enabled = button_get_detail.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.onetc.info/wkmonkey/wan-ke-hou-ge-ti-fen-xi-ruan-jian-di-er-ban");  //利用Process.Start来打开
            linkLabel1.LinkVisited = true;  //链接是否被访问过,仅能代码来实现
        }

        private void MonkeyDetailForm_Load(object sender, EventArgs e)
        {
            try
            {
                var appinfo = _appService.GetAppInfo();

                if (appinfo == null)
                    return;

                if(!appinfo.isEnable)
                {
                    button_get_detail.Enabled = textBox_token.Enabled = false;
                    MessageBox.Show($"该软件已禁止使用，原因：\r\n{appinfo.disableReason}");

                    Application.Exit();
                }

                if(appinfo.minVersionCode> appVersionCode)
                {
                    button_get_detail.Enabled = textBox_token.Enabled = false;
                    if (MessageBox.Show("软件版本过低，请升级后使用。确定将前往下载，取消将退出程序", "升级提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        System.Diagnostics.Process.Start(appinfo.url);  //利用Process.Start来打开
                       
                    }
                    Application.Exit();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
