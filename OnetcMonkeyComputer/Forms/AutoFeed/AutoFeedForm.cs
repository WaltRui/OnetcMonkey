using OnetcMonkeyComputer.Config;
using OnetcMonkeyComputer.Forms.AutoFeed.Libs;
using OnetcMonkeyComputer.Services;
using OnetcMonkeyComputer.Services.Dtos;
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

namespace OnetcMonkeyComputer.Forms.AutoFeed
{
    public partial class AutoFeedForm : Form
    {
        SynchronizationContext _syncContext = null;
        private static Semaphore semaphore = new Semaphore(1, 1);

        private IMonkeyService _monkeyService;
        private IConfigService _configService;

        private bool ForseStopFeed=false;

        private List<MyMonkey4FeedDto> monkeys = new List<MyMonkey4FeedDto>();
        
        public AutoFeedForm()
        {
            InitializeComponent();
            _configService = new ConfigService();
            _monkeyService = new MonkeyService();
        }

        private void AutoFeedForm_Load(object sender, EventArgs e)
        {

            _syncContext = SynchronizationContext.Current;

            LoadMonkey();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = monkeys;

            label_count.Text = $"共 {monkeys.Count} 只";
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(0, 1);
        }

        private void LoadMonkey(int page = 1)
        {
            if (page == 1)
                monkeys = new List<MyMonkey4FeedDto>();
            var token = _configService.ReadConfig()?.Token;
            try
            {
                var requestMonkeys = _monkeyService.GetMyMonkeys(token, page);
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            LoadFeedFangAn(index);
        }

        private void LoadFeedFangAn(int index)
        {
            var monkey = monkeys[index];
            if (monkey.GrowIng > 0)
            {
                MessageBox.Show("今天已经喂过的猴子不能进行自动喂食操作！");
                return;
            }
            FeedFangAnForm ffaf = new FeedFangAnForm(monkey.Id);
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

        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                ForseStopFeed = false;
                Thread recvThread = new Thread(new ParameterizedThreadStart(FeedMonkey));
                recvThread.SetApartmentState(ApartmentState.STA);
                recvThread.Start(new FeedMonkeyInput { monkeys = monkeys, wallet = textBox_feedwallet.Text, pwd = textBox_pwd.Text });
                
                //ThreadPool.QueueUserWorkItem(FeedMonkey, new FeedMonkeyInput { monkeys = monkeys, wallet = textBox_feedwallet.Text, pwd = textBox_pwd.Text });
                //this.Invoke(new Delegate_FeedMonkeys(FeedMonkey),monkeys,textBox_feedwallet.Text,textBox_pwd.Text);          
            }catch(Exception ex)
            {
                MessageBox.Show($"已停止，原因：{ex.Message}");
            }
        }

        private void FeedMonkey(object obj)
        {
            try
            {
                var input = obj as FeedMonkeyInput;

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

        private void FeedOne(MyMonkey4FeedDto m, string wallet, string pwd)
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

        private void button_reload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("重新加载将重置所有已配置的自动喂食方案", "确认重置？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                LoadMonkey();
                label_count.Text = $"共 {monkeys.Count} 只";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = monkeys;
                //delete
            }
        }


        private void Notify(object obj)
        {
            string msg = obj as string;

            if(msg.Contains("全部完成"))
            {
                tabControl1.SelectedTab = tabPage4;
            }
            listBox_log.Items.Insert(0, msg);

        }

        private const int WM_HOTKEY = 0x312; //窗口消息-热键  
        private const int WM_CREATE = 0x1; //窗口消息-创建  
        private const int WM_DESTROY = 0x2; //窗口消息-销毁  
        private const int Space = 0x3572; //热键ID  
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_HOTKEY: //窗口消息-热键ID  
                    ForseStopFeed = true;
                    break;
                case WM_CREATE: //窗口消息-创建  
                    AppHotKey.RegKey(Handle, Space, AppHotKey.KeyModifiers.Ctrl | AppHotKey.KeyModifiers.Shift | AppHotKey.KeyModifiers.Alt, Keys.P);
                    break;
                case WM_DESTROY: //窗口消息-销毁  
                    AppHotKey.UnRegKey(Handle, Space); //销毁热键  
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var feedMonkeys = monkeys.Where(w=>w.IsAuto).ToList();
            if (feedMonkeys.Count == 0)
            {
                MessageBox.Show("最少配置一个猴子的喂养方案！");
                return;
            }
            label6.Text = $"总共选择了{feedMonkeys.Count}只猴子进行自动喂养，喂养总计需要{feedMonkeys.Sum(s=>(s.FeedList.Sum()+s.FeedList.Count*0.01)).ToString("f6")} wkc，请确保钱包内有足够的链克";
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

        private void button_return_Click(object sender, EventArgs e)
        {
            LoadMonkey();
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

    public class FeedMonkeyInput
    {
        public List<MyMonkey4FeedDto> monkeys { get; set; }
        public string wallet { get; set; }
        public string pwd { get; set; }
    }
}
