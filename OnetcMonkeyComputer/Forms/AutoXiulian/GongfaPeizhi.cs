using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnetcMonkeyComputer.Forms.AutoXiulian
{
    public partial class GongfaPeizhi : Form
    {
        private long Id { get; set; }
        public List<double> list { get; set; }
        public string FangAn { get; set; }
        public GongfaPeizhi(long id)
        {
            Id = id;
            InitializeComponent();
        }

        private void GongfaPeizhi_Load(object sender, EventArgs e)
        {
            List<string> xiulianfamens = new List<string>();

            for(int i=0;i<50;i++)
            {
                xiulianfamens.Add($"每次修炼消耗{i+1}.{Id}个wkc");
            }
            comboBox_unit.DataSource = xiulianfamens;
        }

        private void comboBox_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> xiuliantime = new List<string>();

            var index = comboBox_unit.SelectedIndex;
            var unitcost = index + 1;

            var MaxTime = 50 / unitcost;

            for(int i=0;i<MaxTime;i++)
            {
                xiuliantime.Add($"潜心修炼{i+1}次");
            }

            comboBox_time.DataSource = xiuliantime;
            ShowResult();
        }

        private void comboBox_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowResult();
        }

        private void ShowResult()
        {
            list = new List<double>();
            FangAn = comboBox_unit.Text;
            var unit = comboBox_unit.SelectedIndex;
            var time = comboBox_time.SelectedIndex;
            if (unit < 0 || time < 0)
                return;

            var unitcost_str = (unit+1) + "." + Id;
            double unitcost = double.Parse(unitcost_str);
            var xiuliancost = unitcost * (time + 1);
            var shouxufei = 0.01 * (time + 1);
            label3.Text = $"共计消耗 {xiuliancost}wkc 修炼消耗 + {shouxufei} wkc手续费 = {xiuliancost+shouxufei} wkc";

            for(int i =0;i<=time;i++)
            {
                list.Add(unitcost);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            list = null;
            FangAn = null;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
