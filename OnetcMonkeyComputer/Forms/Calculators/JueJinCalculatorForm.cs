using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnetcMonkeyComputer
{
    public partial class JueJinCalculatorForm : Form
    {
        private const int BearCd = 30;
        private const double BearCoefficient = 0.42;
        private const double DecreaseCoefficient = 0.168;
        public JueJinCalculatorForm()
        {
            InitializeComponent();
        }

        private void button_compute_Click(object sender, EventArgs e)
        {
            var generation = (int)numericUpDown_generation.Value;          
            var juejinvalue = (double)numericUpDown_juejin.Value;            
            var tizhong = (double)numericUpDown_tizhong.Value;

            var toushi = (double)numericUpDown_weiyang.Value;

            var generationCoef = ComputeGenerationCoefficient(generation);
 
            //小猴掘金分数=体重*掘金属性值*当日有效投食金额/代系数
            var juejinfenshu = tizhong * juejinvalue * toushi / generationCoef;
            label_result.Text = $"{generation}代系数为：{generationCoef},\r\n\r\n"               
                +$"掘金分数{juejinfenshu}";
        }


        private double ComputeGenerationCoefficient(int generation)
        {
            //目前的标准代数损益系数为0.168，算法为：x代系数 =（1 + 标准系数）^ x，如0代为1，1代就是1.168，2代为1.364。

            return Math.Pow(1 + DecreaseCoefficient, generation);
        }
    }
}
