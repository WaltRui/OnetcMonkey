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

namespace OnetcMonkeyComputer.Forms.Calculators
{
    public partial class GenerationCalculatorForm : Form
    {
        public GenerationCalculatorForm()
        {
            InitializeComponent();
        }


        private const double DecreaseCoefficient = 0.168;
        private double ComputeGenerationCoefficient(int generation)
        {
            //目前的标准代数损益系数为0.168，算法为：x代系数 =（1 + 标准系数）^ x，如0代为1，1代就是1.168，2代为1.364。

            return Math.Pow(1 + DecreaseCoefficient, generation);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var gene = ComputeGenerationCoefficient((int)numericUpDown1.Value);
            label_result.Text = gene.ToString("f6");
        }


        public void CreateChart(ZedGraphControl zgc)
        {
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();

            GraphPane myPane = zgc.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = "代系数增长图";
            myPane.XAxis.Title.Text="代数";
            myPane.YAxis.Title.Text = "代系数";

            FontSpec myFont = new FontSpec("宋体", 20, Color.Gray, false, false, false);
            myPane.Title.FontSpec = myFont;
            myPane.XAxis.Title.FontSpec = myFont;
            myPane.YAxis.Title.FontSpec = myFont;
            myPane.Legend.FontSpec = myFont;

            var MaxGeneration = (int)numericUpDown_max_generation.Value;
            string[] labels = new string[MaxGeneration];

            PointPairList list1 = new PointPairList();
            for (int i = 0; i < MaxGeneration; i++)
            {
                labels[i] = i.ToString();

                double x = i;
                double y1 = ComputeGenerationCoefficient(i);
                list1.Add(x, y1);
            }

            // Generate a red curve with diamond symbols, and "Velocity" in the legend
            LineItem myCurve = myPane.AddCurve("代系数",
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
            zgc.Refresh();
            zgc.AxisChange();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            CreateChart(zedGraphControl_gene);
        }

        private void GenerationCalculatorForm_Load(object sender, EventArgs e)
        {
            CreateChart(zedGraphControl_gene);
        }
    }
}
