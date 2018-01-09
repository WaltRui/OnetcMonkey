using OnetcMonkeyComputer.Config;
using OnetcMonkeyComputer.Forms.AutoFeed;
using OnetcMonkeyComputer.Services;
using OnetcMonkeyComputer.Services.Dtos;
using OnetcMonkeyComputer.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnetcMonkeyComputer.Forms.AutoXiulian
{
    public partial class AutoXiulianForm : Form
    {
        SynchronizationContext _syncContext = null;
        private static Semaphore semaphore = new Semaphore(1, 1);

        private IMonkeyService _monkeyService;
        private IConfigService _configService;

        private bool ForseStopFeed = false;

        private List<MyMonkey4XiuLianDto> monkeys = new List<MyMonkey4XiuLianDto>();
        private List<StudyRecord> studyRecords = new List<StudyRecord>();

        public AutoXiulianForm()
        {
            InitializeComponent();
            _configService = new ConfigService();
            _monkeyService = new MonkeyService();
        }

        private void AutoXiulianForm_Load(object sender, EventArgs e)
        {
            _syncContext = SynchronizationContext.Current;


            LoadMonkey();
            LoadMonkeyStudyRecords();
            SetMonkeyXiulian();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = monkeys;

            label_count.Text = $"共 {monkeys.Count} 只";
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(0, 1);
        }
        
        private void LoadMonkey(int page = 1)
        {
            if (page == 1)
                monkeys = new List<MyMonkey4XiuLianDto>();
            var token = _configService.ReadConfig()?.Token;
            try
            {
                var requestMonkeys = _monkeyService.GetMyMonkeys4XiuLian(token, page);
                monkeys.AddRange(requestMonkeys.records);

                if (requestMonkeys.total > monkeys.Count)
                {
                    LoadMonkey(page + 1);
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("未登录"))
                    MessageBox.Show("请前往  帮助---设置   进行token配置！");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void LoadMonkeyStudyRecords(int page = 1)
        {
            if (page == 1)
                studyRecords = new List<StudyRecord>();
            var token = _configService.ReadConfig()?.Token;
            try
            {
                var requestMonkeys = _monkeyService.GetStudyRecords(token, page);
                studyRecords.AddRange(requestMonkeys.records);

                var lastday = studyRecords.OrderBy(o => o.CreateTime).FirstOrDefault()?.CreateTime;
                var today = DateTimeConverterTool.ConvertDateTimeToInt(DateTime.Now.Date); 
                if (requestMonkeys.total > studyRecords.Count && lastday>= today)
                {
                    LoadMonkeyStudyRecords(page + 1);
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("未登录"))
                    MessageBox.Show("请前往  帮助---设置   进行token配置！");
                else
                    MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            LoadXiuLianFangAn(index);
        }

        private void LoadXiuLianFangAn(int index)
        {
            var monkey = monkeys[index];

            GongfaPeizhi ffaf = new GongfaPeizhi(monkey.Id);
            ffaf.ShowDialog();

            if (ffaf.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                monkey.FeedList = ffaf.list;//获取弹出窗体的属性值

                monkey.Des = ffaf.FangAn;

            }
            dataGridView1.Refresh();
            RefreshBackColor();
        }
        private void RefreshBackColor()
        {
            for (int i = 0; i < monkeys.Count; i++)
            {
                if (monkeys[i].IsAuto)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void button_reload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("重新加载将重置所有已配置的修炼方案", "确认重置？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                LoadMonkey();
                LoadMonkeyStudyRecords();
                SetMonkeyXiulian();
                label_count.Text = $"共 {monkeys.Count} 只";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = monkeys;
            }
        }

        private void SetMonkeyXiulian()
        {
            var today = DateTimeConverterTool.ConvertDateTimeToInt(DateTime.Now.Date);

            monkeys.ForEach(f=>f.XiuLianToday = studyRecords.Where(w => w.MonkeyId == f.Id && w.CreateTime > today).Sum(s => s.Coin));
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var feedMonkeys = monkeys.Where(w => w.IsAuto).ToList();
            if(feedMonkeys.Count==0)
            {
                MessageBox.Show("最少配置一个猴子的修炼方案！");
                return;
            }
            label6.Text = $"总共选择了{feedMonkeys.Count}只猴子进行自动喂养，喂养总计需要{feedMonkeys.Sum(s => (s.FeedList.Sum() + s.FeedList.Count * 0.01)).ToString("f6")} wkc，请确保钱包内有足够的链克";
            tabControl1.SelectedTab = tabPage2;
        }

        private void button_step2_Click(object sender, EventArgs e)
        {
            listBox_log.Items.Clear();
            tabControl1.SelectedTab = tabPage3;
        }

        private void button_step2_pre_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button_start.Enabled = checkBox1.Checked;
        }

        private void button_start_Click(object sender, EventArgs e)
        {

            try
            {
                ForseStopFeed = false;
                //ThreadPool.QueueUserWorkItem(FeedMonkey, new XiuLianMonkeyInput { monkeys = monkeys, wallet = textBox_feedwallet.Text, pwd = textBox_pwd.Text });

                Thread recvThread = new Thread(new ParameterizedThreadStart(FeedMonkey));
                recvThread.SetApartmentState(ApartmentState.STA);
                recvThread.Start(new XiuLianMonkeyInput { monkeys = monkeys, wallet = textBox_feedwallet.Text, pwd = textBox_pwd.Text });

                //this.Invoke(new Delegate_FeedMonkeys(FeedMonkey),monkeys,textBox_feedwallet.Text,textBox_pwd.Text);          
            }
            catch (Exception ex)
            {
                MessageBox.Show($"已停止，原因：{ex.Message}");
            }
        }


        private void FeedMonkey(object obj)
        {
            try
            {
                var input = obj as XiuLianMonkeyInput;

                var feedmonkeys = input.monkeys.Where(w => w.FeedList != null && w.FeedList.Count > 0)
                  .ToList();
                foreach (var m in feedmonkeys)
                {
                    _syncContext.Post(Notify, $"{DateTime.Now.ToString("HH:mm:ss")}--开始喂养猴子#{m.Id}");

                    FeedOne(m, input.wallet, input.pwd);
                    if (ForseStopFeed)
                    {
                        _syncContext.Post(Notify, $"{DateTime.Now.ToString("HH:mm:ss")}--已停止喂养");
                        MessageBox.Show("已停止！");
                        return;
                    }
                }
                _syncContext.Post(Notify, $"{DateTime.Now.ToString("HH:mm:ss")}--全部完成");
                MessageBox.Show("已完成！");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"已停止，原因：{ex.Message}");
            }
        }

        private void FeedOne(MyMonkey4XiuLianDto m, string wallet, string pwd)
        {
            int i = 1;
            foreach (var c in m.FeedList)
            {
                if (ForseStopFeed)
                {
                    _syncContext.Post(Notify, $"{DateTime.Now.ToString("HH:mm:ss")}--用户取消了自动喂养");
                    return;
                }

                _syncContext.Post(Notify, $"{DateTime.Now.ToString("HH:mm:ss")}--正在第{i}次喂养猴子#{m.Id},投食{c} wkc");
                AutoFeedHelper.FeedOneTime(wallet, c, pwd);
                _syncContext.Post(Notify, $"{DateTime.Now.ToString("HH:mm:ss")}--第{i}次喂养猴子#{m.Id},投食{c} wkc 完成");
                i++;
            }
        }

        private void Notify(object obj)
        {
            string msg = obj as string;

            listBox_log.Items.Insert(0, msg);
            if (msg.Contains("全部完成"))
            {
                tabControl1.SelectedTab = tabPage4;
            }


        }

        private void button_return_Click(object sender, EventArgs e)
        {
            LoadMonkey();
            LoadMonkeyStudyRecords();
            SetMonkeyXiulian();
            label_count.Text = $"共 {monkeys.Count} 只";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = monkeys;

            tabControl1.SelectedTab = tabPage1;
        }

        private void button_dashang_Click(object sender, EventArgs e)
        {
            double dashang = (double)numericUpDown1.Value;
            var pwd = textBox_pwd.Text;
            if (MessageBox.Show($"为确认你并非误操作，请再次确认，你要向软件作者打赏{dashang}链克吗？", "二次确认", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                AutoFeedHelper.FeedOneTime("0x365cc7e1ee13579558ec18e4af13233bd91538df", dashang, pwd);
                //delete
            }
        }

        private void button_step3_pre_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.onetc.info/wkmonkey/hai-na-bai-chuan-wan-ke-hou-fu-zhu-gong-ju-3-6-ban-ben-fa-bu-");
        }
    }

    public class XiuLianMonkeyInput
    {
        public List<MyMonkey4XiuLianDto> monkeys { get; set; }
        public string wallet { get; set; }
        public string pwd { get; set; }
    }
}
