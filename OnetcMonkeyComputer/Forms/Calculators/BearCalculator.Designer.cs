namespace OnetcMonkeyComputer
{
    partial class BearCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BearCalculator));
            this.button_calculator = new System.Windows.Forms.Button();
            this.numericUpDown_generation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_bear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_bearNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_cd = new System.Windows.Forms.Label();
            this.label_gene = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_generation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bearNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_calculator
            // 
            this.button_calculator.Location = new System.Drawing.Point(235, 71);
            this.button_calculator.Name = "button_calculator";
            this.button_calculator.Size = new System.Drawing.Size(71, 23);
            this.button_calculator.TabIndex = 0;
            this.button_calculator.Text = "计算";
            this.button_calculator.UseVisualStyleBackColor = true;
            this.button_calculator.Click += new System.EventHandler(this.button_calculator_Click);
            // 
            // numericUpDown_generation
            // 
            this.numericUpDown_generation.Location = new System.Drawing.Point(88, 33);
            this.numericUpDown_generation.Name = "numericUpDown_generation";
            this.numericUpDown_generation.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_generation.TabIndex = 1;
            // 
            // numericUpDown_bear
            // 
            this.numericUpDown_bear.DecimalPlaces = 5;
            this.numericUpDown_bear.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_bear.Location = new System.Drawing.Point(88, 74);
            this.numericUpDown_bear.Name = "numericUpDown_bear";
            this.numericUpDown_bear.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_bear.TabIndex = 2;
            // 
            // numericUpDown_bearNum
            // 
            this.numericUpDown_bearNum.Location = new System.Drawing.Point(88, 115);
            this.numericUpDown_bearNum.Name = "numericUpDown_bearNum";
            this.numericUpDown_bearNum.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_bearNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "代数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "生育值：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "生育次数：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_cd);
            this.groupBox1.Controls.Add(this.label_gene);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_bearNum);
            this.groupBox1.Controls.Add(this.numericUpDown_bear);
            this.groupBox1.Controls.Add(this.numericUpDown_generation);
            this.groupBox1.Controls.Add(this.button_calculator);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 171);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "冷却时间计算";
            // 
            // label_cd
            // 
            this.label_cd.AutoSize = true;
            this.label_cd.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_cd.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_cd.Location = new System.Drawing.Point(450, 80);
            this.label_cd.Name = "label_cd";
            this.label_cd.Size = new System.Drawing.Size(15, 14);
            this.label_cd.TabIndex = 12;
            this.label_cd.Text = "0";
            // 
            // label_gene
            // 
            this.label_gene.AutoSize = true;
            this.label_gene.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_gene.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_gene.Location = new System.Drawing.Point(450, 44);
            this.label_gene.Name = "label_gene";
            this.label_gene.Size = new System.Drawing.Size(15, 14);
            this.label_gene.TabIndex = 11;
            this.label_gene.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(332, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "下次冷却时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(377, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "代系数：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 392);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "规则解释";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 189);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(700, 157);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BearCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BearCalculator";
            this.Text = "猴子冷却计算器---By hnbc.info";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_generation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bearNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_calculator;
        private System.Windows.Forms.NumericUpDown numericUpDown_generation;
        private System.Windows.Forms.NumericUpDown numericUpDown_bear;
        private System.Windows.Forms.NumericUpDown numericUpDown_bearNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_cd;
        private System.Windows.Forms.Label label_gene;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}