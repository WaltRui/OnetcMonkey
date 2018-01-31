using System;
using System.Windows.Forms;

namespace OnetcMonkeyComputer
{
    public partial class BearCalculator : Form
    {
        public BearCalculator()
        {
            InitializeComponent();
        }

        private void button_calculator_Click(object sender, EventArgs e)
        {
            var generation = (int)numericUpDown_generation.Value;
            var bear = (double)numericUpDown_bear.Value;
            var bearNum = (int)numericUpDown_bearNum.Value;
            var daixishu = ComputeGenerationCoefficient(generation);

            var cd = GetBearCd(daixishu,bearNum,bear);

            label_gene.Text = daixishu.ToString("f5");
            label_cd.Text = cd.ToString();

        }

        private const int StandardBearCd = 30;
        private const double BearCoefficient = 0.42;
        private const double DecreaseCoefficient = 0.168;
        public int GetBearCd(double GenerationCoef,int bearNum,double bear)
        {
            var cd = StandardBearCd * Math.Pow(1 + BearCoefficient, bearNum) * GenerationCoef / (1 + Math.Pow(bear, 2) / 10);

            return (int)Math.Round(cd);
        }

        private double ComputeGenerationCoefficient(int generation)
        {
            //目前的标准代数损益系数为0.168，算法为：x代系数 =（1 + 标准系数）^ x，如0代为1，1代就是1.168，2代为1.364。

            return Math.Pow(1 + DecreaseCoefficient, generation);
        }
        
    }
}
