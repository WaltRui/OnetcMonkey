namespace OnetcMonkeyComputer
{
    partial class MonkeyDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonkeyDetailForm));
            this.numericUpDown_monkeyId = new System.Windows.Forms.NumericUpDown();
            this.button_get_detail = new System.Windows.Forms.Button();
            this.label_generationcoeff = new System.Windows.Forms.Label();
            this.label_generation_weight = new System.Windows.Forms.Label();
            this.label_grow = new System.Windows.Forms.Label();
            this.label_bear = new System.Windows.Forms.Label();
            this.label_makemoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label_bearcd = new System.Windows.Forms.Label();
            this.label_juejinfenshu = new System.Windows.Forms.Label();
            this.label_cur_bearcd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_toushi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_token = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_monkeyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_toushi)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_monkeyId
            // 
            this.numericUpDown_monkeyId.Location = new System.Drawing.Point(112, 60);
            this.numericUpDown_monkeyId.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_monkeyId.Name = "numericUpDown_monkeyId";
            this.numericUpDown_monkeyId.Size = new System.Drawing.Size(115, 21);
            this.numericUpDown_monkeyId.TabIndex = 0;
            // 
            // button_get_detail
            // 
            this.button_get_detail.Location = new System.Drawing.Point(179, 132);
            this.button_get_detail.Name = "button_get_detail";
            this.button_get_detail.Size = new System.Drawing.Size(75, 23);
            this.button_get_detail.TabIndex = 1;
            this.button_get_detail.Text = "查询";
            this.button_get_detail.UseVisualStyleBackColor = true;
            this.button_get_detail.Click += new System.EventHandler(this.button_get_detail_Click);
            // 
            // label_generationcoeff
            // 
            this.label_generationcoeff.AutoSize = true;
            this.label_generationcoeff.Location = new System.Drawing.Point(30, 356);
            this.label_generationcoeff.Name = "label_generationcoeff";
            this.label_generationcoeff.Size = new System.Drawing.Size(53, 12);
            this.label_generationcoeff.TabIndex = 2;
            this.label_generationcoeff.Text = "代系数：";
            // 
            // label_generation_weight
            // 
            this.label_generation_weight.AutoSize = true;
            this.label_generation_weight.Location = new System.Drawing.Point(192, 195);
            this.label_generation_weight.Name = "label_generation_weight";
            this.label_generation_weight.Size = new System.Drawing.Size(65, 12);
            this.label_generation_weight.TabIndex = 4;
            this.label_generation_weight.Text = "0代 - 0 kg";
            // 
            // label_grow
            // 
            this.label_grow.AutoSize = true;
            this.label_grow.Location = new System.Drawing.Point(192, 234);
            this.label_grow.Name = "label_grow";
            this.label_grow.Size = new System.Drawing.Size(35, 12);
            this.label_grow.TabIndex = 5;
            this.label_grow.Text = "成长:";
            // 
            // label_bear
            // 
            this.label_bear.AutoSize = true;
            this.label_bear.Location = new System.Drawing.Point(192, 266);
            this.label_bear.Name = "label_bear";
            this.label_bear.Size = new System.Drawing.Size(41, 12);
            this.label_bear.TabIndex = 6;
            this.label_bear.Text = "生育：";
            // 
            // label_makemoney
            // 
            this.label_makemoney.AutoSize = true;
            this.label_makemoney.Location = new System.Drawing.Point(192, 307);
            this.label_makemoney.Name = "label_makemoney";
            this.label_makemoney.Size = new System.Drawing.Size(41, 12);
            this.label_makemoney.TabIndex = 7;
            this.label_makemoney.Text = "掘金：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "玩客猴ID:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(30, 182);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(148, 148);
            this.webBrowser1.TabIndex = 9;
            // 
            // label_bearcd
            // 
            this.label_bearcd.AutoSize = true;
            this.label_bearcd.Location = new System.Drawing.Point(30, 422);
            this.label_bearcd.Name = "label_bearcd";
            this.label_bearcd.Size = new System.Drawing.Size(113, 12);
            this.label_bearcd.TabIndex = 10;
            this.label_bearcd.Text = "下次生育冷却时间：";
            // 
            // label_juejinfenshu
            // 
            this.label_juejinfenshu.AutoSize = true;
            this.label_juejinfenshu.Location = new System.Drawing.Point(30, 455);
            this.label_juejinfenshu.Name = "label_juejinfenshu";
            this.label_juejinfenshu.Size = new System.Drawing.Size(65, 12);
            this.label_juejinfenshu.TabIndex = 11;
            this.label_juejinfenshu.Text = "掘金分数：";
            // 
            // label_cur_bearcd
            // 
            this.label_cur_bearcd.AutoSize = true;
            this.label_cur_bearcd.Location = new System.Drawing.Point(30, 389);
            this.label_cur_bearcd.Name = "label_cur_bearcd";
            this.label_cur_bearcd.Size = new System.Drawing.Size(113, 12);
            this.label_cur_bearcd.TabIndex = 12;
            this.label_cur_bearcd.Text = "最近一次生育时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "今日投食:";
            // 
            // numericUpDown_toushi
            // 
            this.numericUpDown_toushi.DecimalPlaces = 5;
            this.numericUpDown_toushi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_toushi.Location = new System.Drawing.Point(112, 95);
            this.numericUpDown_toushi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_toushi.Name = "numericUpDown_toushi";
            this.numericUpDown_toushi.Size = new System.Drawing.Size(115, 21);
            this.numericUpDown_toushi.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "设置为0将自动计算今日投食总量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "猴子编号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(30, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "因部分猴子从未喂养过，其当日投食、体重为0，掘金分数自然为零。\r\n\r\n为了更合理的体现猴子的掘金价值，将0体重猴子的体重设为 =5*成长系数。";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "token:";
            // 
            // textBox_token
            // 
            this.textBox_token.Location = new System.Drawing.Point(112, 21);
            this.textBox_token.Name = "textBox_token";
            this.textBox_token.Size = new System.Drawing.Size(323, 21);
            this.textBox_token.TabIndex = 19;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(455, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 12);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "如何设置token";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(27, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(509, 36);
            this.label7.TabIndex = 21;
            this.label7.Text = "为保证游戏公平性，本软件仅做属性整理、掘金分数计算。如玩客猴官方认为有违反游戏规则，\r\n\r\n可联系我停用软件，联系方式：UVHvvJoxMjI4MjQwNjQz";
            // 
            // MonkeyDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 587);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox_token);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_toushi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_cur_bearcd);
            this.Controls.Add(this.label_juejinfenshu);
            this.Controls.Add(this.label_bearcd);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_makemoney);
            this.Controls.Add(this.label_bear);
            this.Controls.Add(this.label_grow);
            this.Controls.Add(this.label_generation_weight);
            this.Controls.Add(this.label_generationcoeff);
            this.Controls.Add(this.button_get_detail);
            this.Controls.Add(this.numericUpDown_monkeyId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MonkeyDetailForm";
            this.Text = "玩客猴个体分析（简易版）---By：onetc.info";
            this.Load += new System.EventHandler(this.MonkeyDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_monkeyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_toushi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_monkeyId;
        private System.Windows.Forms.Button button_get_detail;
        private System.Windows.Forms.Label label_generationcoeff;
        private System.Windows.Forms.Label label_generation_weight;
        private System.Windows.Forms.Label label_grow;
        private System.Windows.Forms.Label label_bear;
        private System.Windows.Forms.Label label_makemoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label_bearcd;
        private System.Windows.Forms.Label label_juejinfenshu;
        private System.Windows.Forms.Label label_cur_bearcd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_toushi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_token;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
    }
}