namespace OnetcMonkeyComputer.Forms.AutoFeed
{
    partial class AutoFeedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoFeedForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.体重 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预估掘金分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.今日已喂 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.启用自动喂食 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.喂食方案 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总计喂食 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手续费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总费用 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_step2_pre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_step2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_step3_pre = new System.Windows.Forms.Button();
            this.listBox_log = new System.Windows.Forms.ListBox();
            this.button_start = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.代数,
            this.体重,
            this.预估掘金分,
            this.今日已喂,
            this.启用自动喂食,
            this.喂食方案,
            this.总计喂食,
            this.手续费,
            this.总费用});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(914, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "Id";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.ReadOnly = true;
            this.编号.Width = 80;
            // 
            // 代数
            // 
            this.代数.DataPropertyName = "Generation";
            this.代数.HeaderText = "代数";
            this.代数.Name = "代数";
            this.代数.ReadOnly = true;
            this.代数.Width = 70;
            // 
            // 体重
            // 
            this.体重.DataPropertyName = "Weight";
            this.体重.HeaderText = "体重";
            this.体重.Name = "体重";
            this.体重.ReadOnly = true;
            this.体重.Width = 80;
            // 
            // 预估掘金分
            // 
            this.预估掘金分.DataPropertyName = "JueJinFenShu";
            this.预估掘金分.HeaderText = "预估掘金分";
            this.预估掘金分.Name = "预估掘金分";
            this.预估掘金分.ReadOnly = true;
            // 
            // 今日已喂
            // 
            this.今日已喂.DataPropertyName = "GrowIng";
            this.今日已喂.HeaderText = "今日已喂";
            this.今日已喂.Name = "今日已喂";
            this.今日已喂.ReadOnly = true;
            this.今日已喂.Width = 90;
            // 
            // 启用自动喂食
            // 
            this.启用自动喂食.DataPropertyName = "IsAuto";
            this.启用自动喂食.HeaderText = "启用自动喂食";
            this.启用自动喂食.Name = "启用自动喂食";
            this.启用自动喂食.ReadOnly = true;
            // 
            // 喂食方案
            // 
            this.喂食方案.DataPropertyName = "Des";
            this.喂食方案.HeaderText = "喂食方案";
            this.喂食方案.Name = "喂食方案";
            this.喂食方案.ReadOnly = true;
            // 
            // 总计喂食
            // 
            this.总计喂食.DataPropertyName = "FeedSum";
            this.总计喂食.HeaderText = "总计喂食";
            this.总计喂食.Name = "总计喂食";
            this.总计喂食.ReadOnly = true;
            this.总计喂食.Width = 90;
            // 
            // 手续费
            // 
            this.手续费.DataPropertyName = "FeeSum";
            this.手续费.HeaderText = "手续费";
            this.手续费.Name = "手续费";
            this.手续费.ReadOnly = true;
            this.手续费.Width = 90;
            // 
            // 总费用
            // 
            this.总费用.DataPropertyName = "Cost";
            this.总费用.HeaderText = "总费用";
            this.总费用.Name = "总费用";
            this.总费用.ReadOnly = true;
            this.总费用.Width = 90;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 584);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label_count);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button_reload);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(341, 12);
            this.label22.TabIndex = 6;
            this.label22.Text = "当前已配置0只猴子自动喂养，总计需要0wkc，预计总掘金分：0";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(149, 19);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(35, 12);
            this.label_count.TabIndex = 5;
            this.label_count.Text = "共0只";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "双击猴子可进行配置自动喂食方案。配置完成后点击下一步";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(786, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "下一步";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(526, 32);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(75, 23);
            this.button_reload.TabIndex = 2;
            this.button_reload.Text = "刷新";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "你的所有猴子如下列表：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(50, 179);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(347, 12);
            this.label23.TabIndex = 17;
            this.label23.Text = "1、如自定喂食过程想要终止，可使用快捷键：Ctrl+Shift+Alt+P";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(48, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "使用方法：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_step2_pre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_step2);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 97);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button_step2_pre
            // 
            this.button_step2_pre.Location = new System.Drawing.Point(633, 30);
            this.button_step2_pre.Name = "button_step2_pre";
            this.button_step2_pre.Size = new System.Drawing.Size(75, 23);
            this.button_step2_pre.TabIndex = 6;
            this.button_step2_pre.Text = "上一步";
            this.button_step2_pre.UseVisualStyleBackColor = true;
            this.button_step2_pre.Click += new System.EventHandler(this.button_step2_pre_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(449, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "总共选择了0只猴子进行自动喂养，喂养总计需要0 wkc，请确保钱包内有足够的链克";
            // 
            // button_step2
            // 
            this.button_step2.Location = new System.Drawing.Point(783, 30);
            this.button_step2.Name = "button_step2";
            this.button_step2.Size = new System.Drawing.Size(75, 23);
            this.button_step2.TabIndex = 4;
            this.button_step2.Text = "下一步";
            this.button_step2.UseVisualStyleBackColor = true;
            this.button_step2.Click += new System.EventHandler(this.button_step2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.button_step3_pre);
            this.tabPage3.Controls.Add(this.listBox_log);
            this.tabPage3.Controls.Add(this.button_start);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(920, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "如自定喂食过程想要终止，可使用快捷键：Ctrl+Shift+Alt+P";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "总共选择了0只猴子进行自动喂养，喂养总计需要0 wkc，请确保钱包内有足够的链克";
            // 
            // button_step3_pre
            // 
            this.button_step3_pre.Location = new System.Drawing.Point(634, 110);
            this.button_step3_pre.Name = "button_step3_pre";
            this.button_step3_pre.Size = new System.Drawing.Size(75, 23);
            this.button_step3_pre.TabIndex = 16;
            this.button_step3_pre.Text = "返回上一步";
            this.button_step3_pre.UseVisualStyleBackColor = true;
            this.button_step3_pre.Click += new System.EventHandler(this.button_step3_pre_Click);
            // 
            // listBox_log
            // 
            this.listBox_log.FormattingEnabled = true;
            this.listBox_log.ItemHeight = 12;
            this.listBox_log.Location = new System.Drawing.Point(7, 170);
            this.listBox_log.Name = "listBox_log";
            this.listBox_log.Size = new System.Drawing.Size(906, 364);
            this.listBox_log.TabIndex = 12;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(290, 110);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 7;
            this.button_start.Text = "开始喂养";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(920, 558);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 166);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(87, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(648, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "写个软件不容易，你可愿打赏点链克帮助作者承担点服务器的费用";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(90, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "本软件完全免费。请勿将此软件倒卖、商用。";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 362);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "打赏";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(90, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "打赏全凭自愿，不打赏软件一样使用";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 242);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "钱包地址：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(319, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0x365cc7e1ee13579558ec18e4af13233bd91538df";
            // 
            // AutoFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoFeedForm";
            this.Text = "AutoFeedForm";
            this.Load += new System.EventHandler(this.AutoFeedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox_log;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_step2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_step2_pre;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_step3_pre;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 体重;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预估掘金分;
        private System.Windows.Forms.DataGridViewTextBoxColumn 今日已喂;
        private System.Windows.Forms.DataGridViewTextBoxColumn 启用自动喂食;
        private System.Windows.Forms.DataGridViewTextBoxColumn 喂食方案;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总计喂食;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手续费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总费用;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}