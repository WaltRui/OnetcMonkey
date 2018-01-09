using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnetcMonkeyComputer.Forms.AutoFeed
{
    public partial class FeedFangAnForm : Form
    {
        public List<double> list = new List<double>();
        public string FangAn = "";
        public long MonkeyId;

        public FeedFangAnForm(long Id)
        {
            MonkeyId = Id;
            InitializeComponent();


        }

        

        private void comboBox_fangan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FangAn = comboBox_fangan.Text;
            var minBigNum = comboBox_fangan.SelectedIndex;
            minBigNum = minBigNum < 0 ? 0 : minBigNum;

            var toushi = FeedFangan((int)numericUpDown_Id.Value, minBigNum);

            list = GetTsZuhe(toushi);

            ShowFeedFangan(list, listBox1);

            label_result.Text = $"投食{toushi.Num}次，共计实际投食 {toushi.Num * toushi.Minfeed + toushi.BigTsNum} wkc + 手续费 {0.01 * toushi.Num} wkc  = {toushi.Num * toushi.Minfeed + toushi.BigTsNum + 0.01 * toushi.Num} wkc";
        }

        private void ShowFeedFangan(List<double> list, ListBox listbox)
        {
            listbox.Items.Clear();

            var a = list.OrderBy(o => o).ToList();

            for (int i = a.Count - 1; i >= 0; i--)
            {
                listbox.Items.Add($"第{a.Count - i}次投食：{a[i]} wck");
            }

        }

        private List<double> GetTsZuhe(Toushi ts)
        {
            List<double> list = new List<double>();

            int per = 1;
            int left = ts.BigTsNum;
            if (ts.Num > ts.BigTsNum)
            {
                for (int i = 0; i < ts.Num; i++)
                {
                    if (left > 0)
                    {
                        list.Add(per + ts.Minfeed);
                        left = left - per;
                    }
                    else
                    {
                        list.Add(ts.Minfeed);
                    }
                }
            }
            else
            {
                for (int i = 0; i < ts.Num; i++)
                {
                    if (i == ts.Num - 1)
                    {
                        list.Add(left + ts.Minfeed);
                    }
                    else
                    {
                        list.Add(per + ts.Minfeed);
                        left = left - per;
                    }

                }

            }

            return list;
        }


        private Toushi FeedFangan(int bianhao, int minBigNum)
        {
            List<Toushi> tsList = new List<Toushi>();

            for (int i = 4; i >= minBigNum; i--)
            {
                tsList.Add(ToushiTest(bianhao, i));
            }

            Toushi best = tsList
                .OrderBy(o => o.NoFeed)
                .ToList()
                .FirstOrDefault();
            return best;
        }


        private Toushi ToushiTest(int bianhao, int intfeed)
        {
            var length = bianhao.ToString().Length;

            var chushu = (int)Math.Pow(10, length);

            var minfeed = bianhao * 1.0 / chushu;

            double num_double = (5 - intfeed) / minfeed;

            int num = (int)Math.Floor(num_double);

            double left = (5 - intfeed) - num * minfeed;

            return new Toushi(num, left, intfeed, minfeed);

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 20;
        }

        private void FeedFangAnForm_Load(object sender, EventArgs e)
        {
            numericUpDown_Id.Value = MonkeyId;
            comboBox_fangan.SelectedIndex = 0;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            list = null;
            FangAn = null;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    public class Toushi
    {
        public Toushi(int num, double nofeed, int big, double minfeed)
        {
            Num = num;
            NoFeed = nofeed;
            BigTsNum = big;
            Minfeed = minfeed;
        }

        public int BigTsNum { get; set; }

        public int Num { get; set; }

        public double Minfeed { get; set; }

        public double NoFeed { get; set; }

    }
}
