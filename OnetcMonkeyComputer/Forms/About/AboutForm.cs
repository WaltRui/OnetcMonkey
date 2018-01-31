using OnetcMonkeyComputer.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnetcMonkeyComputer.Forms.About
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label2.Text = $"软件版本：V{AppInfo.AppVersion}";
            label3.Text = $"版本代码：{AppInfo.VersionCode}";
        }
    }
}
