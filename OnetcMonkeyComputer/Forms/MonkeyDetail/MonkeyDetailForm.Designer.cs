namespace OnetcMonkeyComputer.Forms.MonkeyDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonkeyDetailForm));
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_monkeyId = new System.Windows.Forms.NumericUpDown();
            this.label_makemoney = new System.Windows.Forms.Label();
            this.label_bear = new System.Windows.Forms.Label();
            this.label_grow = new System.Windows.Forms.Label();
            this.label_generation_weight = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_cur_bearcd = new System.Windows.Forms.Label();
            this.label_juejinfenshu = new System.Windows.Forms.Label();
            this.label_bearcd = new System.Windows.Forms.Label();
            this.label_generationcoeff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControl_juejin = new ZedGraph.ZedGraphControl();
            this.tabPage_coin_chart = new System.Windows.Forms.TabPage();
            this.zedGraphControl_coin = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_get_detail = new System.Windows.Forms.Button();
            this.webKitBrowser_radar = new WebKit.WebKitBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_monkeyId)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage_coin_chart.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "玩客猴ID:";
            // 
            // numericUpDown_monkeyId
            // 
            this.numericUpDown_monkeyId.Location = new System.Drawing.Point(92, 24);
            this.numericUpDown_monkeyId.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_monkeyId.Name = "numericUpDown_monkeyId";
            this.numericUpDown_monkeyId.Size = new System.Drawing.Size(115, 21);
            this.numericUpDown_monkeyId.TabIndex = 17;
            // 
            // label_makemoney
            // 
            this.label_makemoney.AutoSize = true;
            this.label_makemoney.Location = new System.Drawing.Point(213, 212);
            this.label_makemoney.Name = "label_makemoney";
            this.label_makemoney.Size = new System.Drawing.Size(41, 12);
            this.label_makemoney.TabIndex = 24;
            this.label_makemoney.Text = "掘金：";
            // 
            // label_bear
            // 
            this.label_bear.AutoSize = true;
            this.label_bear.Location = new System.Drawing.Point(213, 165);
            this.label_bear.Name = "label_bear";
            this.label_bear.Size = new System.Drawing.Size(41, 12);
            this.label_bear.TabIndex = 23;
            this.label_bear.Text = "生育：";
            // 
            // label_grow
            // 
            this.label_grow.AutoSize = true;
            this.label_grow.Location = new System.Drawing.Point(213, 118);
            this.label_grow.Name = "label_grow";
            this.label_grow.Size = new System.Drawing.Size(35, 12);
            this.label_grow.TabIndex = 22;
            this.label_grow.Text = "成长:";
            // 
            // label_generation_weight
            // 
            this.label_generation_weight.AutoSize = true;
            this.label_generation_weight.Location = new System.Drawing.Point(213, 71);
            this.label_generation_weight.Name = "label_generation_weight";
            this.label_generation_weight.Size = new System.Drawing.Size(65, 12);
            this.label_generation_weight.TabIndex = 21;
            this.label_generation_weight.Text = "0代 - 0 kg";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage_coin_chart);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 263);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 303);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label_cur_bearcd);
            this.tabPage1.Controls.Add(this.label_juejinfenshu);
            this.tabPage1.Controls.Add(this.label_bearcd);
            this.tabPage1.Controls.Add(this.label_generationcoeff);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label_money);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(862, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "简介";
            // 
            // label_cur_bearcd
            // 
            this.label_cur_bearcd.AutoSize = true;
            this.label_cur_bearcd.Location = new System.Drawing.Point(28, 121);
            this.label_cur_bearcd.Name = "label_cur_bearcd";
            this.label_cur_bearcd.Size = new System.Drawing.Size(113, 12);
            this.label_cur_bearcd.TabIndex = 39;
            this.label_cur_bearcd.Text = "最近一次生育时间：";
            // 
            // label_juejinfenshu
            // 
            this.label_juejinfenshu.AutoSize = true;
            this.label_juejinfenshu.Location = new System.Drawing.Point(28, 187);
            this.label_juejinfenshu.Name = "label_juejinfenshu";
            this.label_juejinfenshu.Size = new System.Drawing.Size(65, 12);
            this.label_juejinfenshu.TabIndex = 38;
            this.label_juejinfenshu.Text = "掘金分数：";
            // 
            // label_bearcd
            // 
            this.label_bearcd.AutoSize = true;
            this.label_bearcd.Location = new System.Drawing.Point(28, 154);
            this.label_bearcd.Name = "label_bearcd";
            this.label_bearcd.Size = new System.Drawing.Size(113, 12);
            this.label_bearcd.TabIndex = 37;
            this.label_bearcd.Text = "下次生育冷却时间：";
            // 
            // label_generationcoeff
            // 
            this.label_generationcoeff.AutoSize = true;
            this.label_generationcoeff.Location = new System.Drawing.Point(28, 88);
            this.label_generationcoeff.Name = "label_generationcoeff";
            this.label_generationcoeff.Size = new System.Drawing.Size(53, 12);
            this.label_generationcoeff.TabIndex = 36;
            this.label_generationcoeff.Text = "代系数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(31, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 35;
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Location = new System.Drawing.Point(28, 220);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(65, 12);
            this.label_money.TabIndex = 34;
            this.label_money.Text = "收益预估：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.zedGraphControl_juejin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "掘金分数走势";
            // 
            // zedGraphControl_juejin
            // 
            this.zedGraphControl_juejin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl_juejin.IsShowPointValues = true;
            this.zedGraphControl_juejin.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl_juejin.Name = "zedGraphControl_juejin";
            this.zedGraphControl_juejin.ScrollGrace = 0D;
            this.zedGraphControl_juejin.ScrollMaxX = 0D;
            this.zedGraphControl_juejin.ScrollMaxY = 0D;
            this.zedGraphControl_juejin.ScrollMaxY2 = 0D;
            this.zedGraphControl_juejin.ScrollMinX = 0D;
            this.zedGraphControl_juejin.ScrollMinY = 0D;
            this.zedGraphControl_juejin.ScrollMinY2 = 0D;
            this.zedGraphControl_juejin.Size = new System.Drawing.Size(856, 271);
            this.zedGraphControl_juejin.TabIndex = 1;
            this.zedGraphControl_juejin.UseExtendedPrintDialog = true;
            // 
            // tabPage_coin_chart
            // 
            this.tabPage_coin_chart.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_coin_chart.Controls.Add(this.zedGraphControl_coin);
            this.tabPage_coin_chart.Location = new System.Drawing.Point(4, 22);
            this.tabPage_coin_chart.Name = "tabPage_coin_chart";
            this.tabPage_coin_chart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_coin_chart.Size = new System.Drawing.Size(862, 277);
            this.tabPage_coin_chart.TabIndex = 3;
            this.tabPage_coin_chart.Text = "每日收益走势";
            // 
            // zedGraphControl_coin
            // 
            this.zedGraphControl_coin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl_coin.IsShowPointValues = true;
            this.zedGraphControl_coin.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl_coin.Name = "zedGraphControl_coin";
            this.zedGraphControl_coin.ScrollGrace = 0D;
            this.zedGraphControl_coin.ScrollMaxX = 0D;
            this.zedGraphControl_coin.ScrollMaxY = 0D;
            this.zedGraphControl_coin.ScrollMaxY2 = 0D;
            this.zedGraphControl_coin.ScrollMinX = 0D;
            this.zedGraphControl_coin.ScrollMinY = 0D;
            this.zedGraphControl_coin.ScrollMinY2 = 0D;
            this.zedGraphControl_coin.Size = new System.Drawing.Size(856, 271);
            this.zedGraphControl_coin.TabIndex = 2;
            this.zedGraphControl_coin.UseExtendedPrintDialog = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(862, 277);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "名词解释";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(856, 271);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_get_detail
            // 
            this.button_get_detail.Location = new System.Drawing.Point(325, 24);
            this.button_get_detail.Name = "button_get_detail";
            this.button_get_detail.Size = new System.Drawing.Size(75, 23);
            this.button_get_detail.TabIndex = 31;
            this.button_get_detail.Text = "查询";
            this.button_get_detail.UseVisualStyleBackColor = true;
            this.button_get_detail.Click += new System.EventHandler(this.button_get_detail_Click);
            // 
            // webKitBrowser_radar
            // 
            this.webKitBrowser_radar.BackColor = System.Drawing.SystemColors.Control;
            this.webKitBrowser_radar.Location = new System.Drawing.Point(572, 24);
            this.webKitBrowser_radar.Name = "webKitBrowser_radar";
            this.webKitBrowser_radar.Size = new System.Drawing.Size(244, 237);
            this.webKitBrowser_radar.TabIndex = 32;
            this.webKitBrowser_radar.Url = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webKitBrowser_radar);
            this.groupBox2.Controls.Add(this.button_get_detail);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Controls.Add(this.label_makemoney);
            this.groupBox2.Controls.Add(this.label_bear);
            this.groupBox2.Controls.Add(this.label_grow);
            this.groupBox2.Controls.Add(this.label_generation_weight);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown_monkeyId);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 572);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "猴";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 51);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(195, 206);
            this.webBrowser1.TabIndex = 25;
            // 
            // MonkeyDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonkeyDetailForm";
            this.Text = "MonkeyDetailForm";
            this.Load += new System.EventHandler(this.MonkeyDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_monkeyId)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage_coin_chart.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_monkeyId;
        private System.Windows.Forms.Label label_makemoney;
        private System.Windows.Forms.Label label_bear;
        private System.Windows.Forms.Label label_grow;
        private System.Windows.Forms.Label label_generation_weight;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_get_detail;
        private WebKit.WebKitBrowser webKitBrowser_radar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_cur_bearcd;
        private System.Windows.Forms.Label label_juejinfenshu;
        private System.Windows.Forms.Label label_bearcd;
        private System.Windows.Forms.Label label_generationcoeff;
        private ZedGraph.ZedGraphControl zedGraphControl_juejin;
        private System.Windows.Forms.TabPage tabPage_coin_chart;
        private System.Windows.Forms.TabPage tabPage3;
        private ZedGraph.ZedGraphControl zedGraphControl_coin;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}