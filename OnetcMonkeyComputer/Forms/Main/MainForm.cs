using OnetcMonkeyComputer.AppServices;
using OnetcMonkeyComputer.Config;
using OnetcMonkeyComputer.Forms.About;
using OnetcMonkeyComputer.Forms.Announce;
using OnetcMonkeyComputer.Forms.AutoFeed;
using OnetcMonkeyComputer.Forms.AutoXiulian;
using OnetcMonkeyComputer.Forms.Calculators;
using OnetcMonkeyComputer.Forms.Donate;
using OnetcMonkeyComputer.Forms.HomePage;
using OnetcMonkeyComputer.Forms.MonkeyDetail;
using OnetcMonkeyComputer.Forms.Overview;
using OnetcMonkeyComputer.Forms.Setting;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OnetcMonkeyComputer.Forms.Main
{
    public partial class MainForm : Form
    {
        public delegate void LoadData();

        private static readonly Lazy<HomePageForm> homePageForm = new Lazy<HomePageForm>();
        private static readonly Lazy<SettingForm> settingForm = new Lazy<SettingForm>();
        private static readonly Lazy<JueJinCalculatorForm> juejinCalculatorForm = new Lazy<JueJinCalculatorForm>();
        private static readonly Lazy<BearCalculator> bearCalculatorForm = new Lazy<BearCalculator>();
        private static readonly Lazy<GenerationCalculatorForm> generationCalculatorForm = new Lazy<GenerationCalculatorForm>();
        private static readonly Lazy<FeedCalculatorForm> feedCalculatorForm = new Lazy<FeedCalculatorForm>();
        private static readonly Lazy<MonkeyDetailForm> monkeyDetailForm = new Lazy<MonkeyDetailForm>();
        private static readonly Lazy<DonateForm> donateForm = new Lazy<DonateForm>();
        private static readonly Lazy<OverViewForm> overViewForm = new Lazy<OverViewForm>();
        private static readonly Lazy<Search> searchForm = new Lazy<Search>();
        private static readonly Lazy<AutoFeedForm> autoFeedForm = new Lazy<AutoFeedForm>();
        private static readonly Lazy<AutoXiulianForm> autoXiulianForm = new Lazy<AutoXiulianForm>();

        


        private IConfigService _configservice;
        
        private void SetForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_forms.Controls.Clear();
            panel_forms.Controls.Add(form);
            form.Show();
        }

        public MainForm()
        {
            InitializeComponent();

            _configservice = new ConfigService();
        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(homePageForm.Value);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"{AppInfo.AppShowName} V{AppInfo.AppVersion} --- By {AppInfo.Author}";
            SetForm(homePageForm.Value);
            UpdateAppInfo();
            var userconfig = _configservice.GetUserConfig();
            if (userconfig.IsSearchEnable)
            {
                猴子筛选器ToolStripMenuItem.Visible = true;
            }
            if (userconfig.Disabled)
            {
                MessageBox.Show("软件已被禁止使用！");
                System.Environment.Exit(0);
            }
        }

        private void 掘金值计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(juejinCalculatorForm.Value);
        }

        private void 生育冷却计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(bearCalculatorForm.Value);
        }

        private void 代系数计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(generationCalculatorForm.Value);
        }
        

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(settingForm.Value);
        }

        private void 投食ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetForm(feedCalculatorForm.Value);            
        }

        private void 个体猴子查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(monkeyDetailForm.Value);            
        }

        private void 捐助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(donateForm.Value);            
        }

        private void 热度排行榜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发中。。。");
        }

        private void 掘金值排行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发中。。。");
        }

        private void 意见反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("邮箱：hnbcinfo@163.com");
        }

        private void 声明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnounceForm form = new AnnounceForm();
            form.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();            
        }

        private void 全网数据总览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(overViewForm.Value);
        }
        

        private void UpdateAppInfo()
        {
            this.Invoke(new LoadData(GetAppInfo));

        }

        private void GetAppInfo()
        {
            try
            {
                IAppService appservice = new AppService();

                var app = appservice.GetAppInfo();

                if (!app.isEnable)
                {
                    MessageBox.Show($"该软件已停止使用，原因如下：{app.disableReason}");

                    System.Environment.Exit(0);
                }
                if (app.minVersionCode > AppInfo.VersionCode)
                {
                    if (MessageBox.Show("该软件版本太低，是否前往下载最新版", "版本升级", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Process.Start(app.url);
                    }
                    System.Environment.Exit(0);
                }
            }
            catch(Exception ee) {
                MessageBox.Show("版本检查失败，部分功能可能不可使用！");
            }
        }

        private void 猴子筛选器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(searchForm.Value);
            
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.onetc.info/wkmonkey/hai-na-bai-chuan-wan-ke-hou-fu-zhu-gong-ju-3-0-fa-bu-");
        }

        private void 自动喂食ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(autoFeedForm.Value);
        }

        private void 自动修炼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(autoXiulianForm.Value);            
        }

        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IAppService appservice = new AppService();

                var app = appservice.GetAppInfo();
                 
                if(app.newestVersion >AppInfo.VersionCode)
                {
                    if (MessageBox.Show($"发现新版本，是否前往下载？", "版本更新", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Process.Start(app.url);
                    }
                }
                else
                {
                    MessageBox.Show("当前为最新版本！");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("版本检查失败，请稍后再试！");
            }
        }
    }
}
