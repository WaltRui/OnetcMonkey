namespace OnetcMonkeyComputer
{
    partial class JueJinCalculatorForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JueJinCalculatorForm));
            this.numericUpDown_juejin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button_compute = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_generation = new System.Windows.Forms.NumericUpDown();
            this.label_result = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_tizhong = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_weiyang = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_juejin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_generation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tizhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weiyang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_juejin
            // 
            this.numericUpDown_juejin.DecimalPlaces = 2;
            this.numericUpDown_juejin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_juejin.Location = new System.Drawing.Point(317, 32);
            this.numericUpDown_juejin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_juejin.Name = "numericUpDown_juejin";
            this.numericUpDown_juejin.Size = new System.Drawing.Size(91, 21);
            this.numericUpDown_juejin.TabIndex = 3;
            this.numericUpDown_juejin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "掘金：";
            // 
            // button_compute
            // 
            this.button_compute.Location = new System.Drawing.Point(189, 128);
            this.button_compute.Name = "button_compute";
            this.button_compute.Size = new System.Drawing.Size(75, 23);
            this.button_compute.TabIndex = 6;
            this.button_compute.Text = "计算";
            this.button_compute.UseVisualStyleBackColor = true;
            this.button_compute.Click += new System.EventHandler(this.button_compute_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "代数：";
            // 
            // numericUpDown_generation
            // 
            this.numericUpDown_generation.Location = new System.Drawing.Point(102, 32);
            this.numericUpDown_generation.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_generation.Name = "numericUpDown_generation";
            this.numericUpDown_generation.Size = new System.Drawing.Size(91, 21);
            this.numericUpDown_generation.TabIndex = 7;
            this.numericUpDown_generation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(483, 34);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(65, 12);
            this.label_result.TabIndex = 11;
            this.label_result.Text = "计算结果：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "体重：";
            // 
            // numericUpDown_tizhong
            // 
            this.numericUpDown_tizhong.DecimalPlaces = 2;
            this.numericUpDown_tizhong.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_tizhong.Location = new System.Drawing.Point(102, 67);
            this.numericUpDown_tizhong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_tizhong.Name = "numericUpDown_tizhong";
            this.numericUpDown_tizhong.Size = new System.Drawing.Size(91, 21);
            this.numericUpDown_tizhong.TabIndex = 12;
            this.numericUpDown_tizhong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "今日投食：";
            // 
            // numericUpDown_weiyang
            // 
            this.numericUpDown_weiyang.DecimalPlaces = 2;
            this.numericUpDown_weiyang.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_weiyang.Location = new System.Drawing.Point(317, 67);
            this.numericUpDown_weiyang.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_weiyang.Name = "numericUpDown_weiyang";
            this.numericUpDown_weiyang.Size = new System.Drawing.Size(91, 21);
            this.numericUpDown_weiyang.TabIndex = 14;
            this.numericUpDown_weiyang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 361);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // JueJinCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_weiyang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_tizhong);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_generation);
            this.Controls.Add(this.button_compute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_juejin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JueJinCalculatorForm";
            this.Text = "生育冷却";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_juejin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_generation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tizhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weiyang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown_juejin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_compute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_generation;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_tizhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_weiyang;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

