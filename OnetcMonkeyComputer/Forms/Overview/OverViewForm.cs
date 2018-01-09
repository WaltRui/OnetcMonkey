using OnetcMonkeyComputer.Config;
using OnetcMonkeyComputer.Services.HnbcServices.Dtos;
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

namespace OnetcMonkeyComputer.Forms.Overview
{
    public partial class OverViewForm : Form
    {
        private IConfigService _configService;

        private List<OverViewDataDto> data;
        public OverViewForm()
        {
            InitializeComponent();
            _configService = new ConfigService();
        }

        private void OverViewForm_Load(object sender, EventArgs e)
        {
            dataGridView_overview.AutoGenerateColumns = false;
            data = _configService.ReadOverViewData();
            dataGridView_overview.DataSource = data;
        }

        private void comboBox_datatype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DrawLineJueJin(data, zedGraphControl1, (DataType)comboBox_datatype.SelectedIndex);
            }
            catch { }
        }

        private void DrawLineJueJin(List<OverViewDataDto> data, ZedGraphControl zgc, DataType type)
        {
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();

            GraphPane myPane = zgc.GraphPane;

            switch(type)
            {
                case DataType.AllMoney:
                    myPane.Title.Text = "掘金池走势";
                    break;
                case DataType.AllScore:
                    myPane.Title.Text = "掘金分数走势";
                    break;
                case DataType.Bear:
                    myPane.Title.Text = "生育金额走势";
                    break;
                case DataType.Feed:
                    myPane.Title.Text = "投食金额走势";
                    break;
                case DataType.Trade:
                    myPane.Title.Text = "交易金额走势";
                    break;

            }
            
            myPane.XAxis.Title.IsVisible = false;
            myPane.YAxis.Title.IsVisible = false;

            //更改标题的字体
            FontSpec myFont = new FontSpec("宋体", 20, Color.Gray, false, false, false);
            myPane.Title.FontSpec = myFont;
            myPane.XAxis.Title.FontSpec = myFont;
            myPane.YAxis.Title.FontSpec = myFont;
            myPane.Legend.FontSpec = myFont;
            
            data = data.OrderBy(o => o.Date).ToList();
            var count = data.Count;
            string[] labels = new string[count];

            PointPairList list1 = new PointPairList();
            for (int i = 0; i < count; i++)
            {
                var dto = data[i];
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
                double y1 = 0;

                switch (type)
                {
                    case DataType.AllMoney:
                        y1 = dto.AllMakeMoney;
                        break;
                    case DataType.AllScore:
                        y1 = dto.AllMakeMoneyScore;
                        break;
                    case DataType.Bear:
                        y1 = dto.Bear;
                        break;
                    case DataType.Feed:
                        y1 = dto.Feed;
                        break;
                    case DataType.Trade:
                        y1 = dto.Trade;
                        break;
                }
                list1.Add(x, y1);
            }

            // 用list1生产一条曲线
            LineItem myCurve = myPane.AddCurve("走势", list1, Color.Red, SymbolType.Circle);

            //填充图表颜色
            myPane.Fill = new Fill(Color.White, Color.FromArgb(200, 200, 255), 45.0f);

            myPane.XAxis.Scale.TextLabels = labels; //X轴文本取值
            myPane.XAxis.Type = AxisType.Text;   //X轴类型

            //画到zedGraphControl1控件中，此句必加
            zgc.AxisChange();
            //重绘控件
            Refresh();
        }

       
    }
    public enum DataType
    {
        AllMoney,
        AllScore,
        Trade,
        Bear,
        Feed,
    }
}
