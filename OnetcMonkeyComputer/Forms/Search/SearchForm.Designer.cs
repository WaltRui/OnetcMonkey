namespace OnetcMonkeyComputer
{
    partial class Search
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
            this.label_generation = new System.Windows.Forms.Label();
            this.numericUpDown_genStart = new System.Windows.Forms.NumericUpDown();
            this.button_search = new System.Windows.Forms.Button();
            this.timer_search = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_sort = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_pages = new System.Windows.Forms.ComboBox();
            this.comboBox_orderby = new System.Windows.Forms.ComboBox();
            this.dataGridView_monkeys = new System.Windows.Forms.DataGridView();
            this.numericUpDown_genEnd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_weightEnd = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_weightStart = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_growEnd = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_growStart = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_bearEnd = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_bearStart = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown_makeMoneyEnd = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown_makeMoneyStart = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_bearNumEnd = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_bearNumStart = new System.Windows.Forms.NumericUpDown();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.掘金分数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.体重 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成长值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生育值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.掘金值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生育次数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_genStart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_monkeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_genEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weightEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weightStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_growEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_growStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bearEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bearStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_makeMoneyEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_makeMoneyStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bearNumEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bearNumStart)).BeginInit();
            this.SuspendLayout();
            // 
            // label_generation
            // 
            this.label_generation.AutoSize = true;
            this.label_generation.Location = new System.Drawing.Point(31, 22);
            this.label_generation.Name = "label_generation";
            this.label_generation.Size = new System.Drawing.Size(41, 12);
            this.label_generation.TabIndex = 3;
            this.label_generation.Text = "代数：";
            // 
            // numericUpDown_genStart
            // 
            this.numericUpDown_genStart.Location = new System.Drawing.Point(78, 19);
            this.numericUpDown_genStart.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_genStart.Name = "numericUpDown_genStart";
            this.numericUpDown_genStart.Size = new System.Drawing.Size(43, 21);
            this.numericUpDown_genStart.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(365, 123);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 11;
            this.button_search.Text = "查找";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_bearNumEnd);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.numericUpDown_bearNumStart);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericUpDown_makeMoneyEnd);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDown_makeMoneyStart);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericUpDown_bearEnd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numericUpDown_bearStart);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDown_growEnd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericUpDown_growStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_weightEnd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDown_weightStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown_genEnd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox_sort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_pages);
            this.groupBox1.Controls.Add(this.comboBox_orderby);
            this.groupBox1.Controls.Add(this.label_generation);
            this.groupBox1.Controls.Add(this.numericUpDown_genStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 105);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "只";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "前";
            // 
            // checkBox_sort
            // 
            this.checkBox_sort.AutoSize = true;
            this.checkBox_sort.Location = new System.Drawing.Point(610, 70);
            this.checkBox_sort.Name = "checkBox_sort";
            this.checkBox_sort.Size = new System.Drawing.Size(48, 16);
            this.checkBox_sort.TabIndex = 13;
            this.checkBox_sort.Text = "倒序";
            this.checkBox_sort.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "排序：";
            // 
            // comboBox_pages
            // 
            this.comboBox_pages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pages.FormattingEnabled = true;
            this.comboBox_pages.Items.AddRange(new object[] {
            "21",
            "42",
            "63",
            "84",
            "105"});
            this.comboBox_pages.Location = new System.Drawing.Point(732, 67);
            this.comboBox_pages.Name = "comboBox_pages";
            this.comboBox_pages.Size = new System.Drawing.Size(88, 20);
            this.comboBox_pages.TabIndex = 11;
            // 
            // comboBox_orderby
            // 
            this.comboBox_orderby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_orderby.FormattingEnabled = true;
            this.comboBox_orderby.Items.AddRange(new object[] {
            "价格",
            "年龄",
            "体重"});
            this.comboBox_orderby.Location = new System.Drawing.Point(507, 68);
            this.comboBox_orderby.Name = "comboBox_orderby";
            this.comboBox_orderby.Size = new System.Drawing.Size(88, 20);
            this.comboBox_orderby.TabIndex = 10;
            // 
            // dataGridView_monkeys
            // 
            this.dataGridView_monkeys.AllowUserToAddRows = false;
            this.dataGridView_monkeys.AllowUserToDeleteRows = false;
            this.dataGridView_monkeys.AllowUserToOrderColumns = true;
            this.dataGridView_monkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_monkeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_monkeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.代数,
            this.价格,
            this.掘金分数,
            this.体重,
            this.成长值,
            this.生育值,
            this.掘金值,
            this.生育次数});
            this.dataGridView_monkeys.Location = new System.Drawing.Point(12, 152);
            this.dataGridView_monkeys.Name = "dataGridView_monkeys";
            this.dataGridView_monkeys.RowTemplate.Height = 23;
            this.dataGridView_monkeys.Size = new System.Drawing.Size(910, 432);
            this.dataGridView_monkeys.TabIndex = 16;
            this.dataGridView_monkeys.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_monkeys_ColumnHeaderMouseClick);
            // 
            // numericUpDown_genEnd
            // 
            this.numericUpDown_genEnd.Location = new System.Drawing.Point(151, 19);
            this.numericUpDown_genEnd.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_genEnd.Name = "numericUpDown_genEnd";
            this.numericUpDown_genEnd.Size = new System.Drawing.Size(41, 21);
            this.numericUpDown_genEnd.TabIndex = 16;
            this.numericUpDown_genEnd.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "-";
            // 
            // numericUpDown_weightEnd
            // 
            this.numericUpDown_weightEnd.Location = new System.Drawing.Point(366, 19);
            this.numericUpDown_weightEnd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_weightEnd.Name = "numericUpDown_weightEnd";
            this.numericUpDown_weightEnd.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown_weightEnd.TabIndex = 20;
            this.numericUpDown_weightEnd.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "体重：";
            // 
            // numericUpDown_weightStart
            // 
            this.numericUpDown_weightStart.DecimalPlaces = 2;
            this.numericUpDown_weightStart.Location = new System.Drawing.Point(275, 19);
            this.numericUpDown_weightStart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_weightStart.Name = "numericUpDown_weightStart";
            this.numericUpDown_weightStart.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown_weightStart.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "-";
            // 
            // numericUpDown_growEnd
            // 
            this.numericUpDown_growEnd.DecimalPlaces = 2;
            this.numericUpDown_growEnd.Location = new System.Drawing.Point(596, 20);
            this.numericUpDown_growEnd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_growEnd.Name = "numericUpDown_growEnd";
            this.numericUpDown_growEnd.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown_growEnd.TabIndex = 24;
            this.numericUpDown_growEnd.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "成长值：";
            // 
            // numericUpDown_growStart
            // 
            this.numericUpDown_growStart.DecimalPlaces = 2;
            this.numericUpDown_growStart.Location = new System.Drawing.Point(505, 20);
            this.numericUpDown_growStart.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_growStart.Name = "numericUpDown_growStart";
            this.numericUpDown_growStart.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown_growStart.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(803, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "-";
            // 
            // numericUpDown_bearEnd
            // 
            this.numericUpDown_bearEnd.DecimalPlaces = 2;
            this.numericUpDown_bearEnd.Location = new System.Drawing.Point(823, 21);
            this.numericUpDown_bearEnd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_bearEnd.Name = "numericUpDown_bearEnd";
            this.numericUpDown_bearEnd.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown_bearEnd.TabIndex = 28;
            this.numericUpDown_bearEnd.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(673, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "生育值：";
            // 
            // numericUpDown_bearStart
            // 
            this.numericUpDown_bearStart.DecimalPlaces = 2;
            this.numericUpDown_bearStart.Location = new System.Drawing.Point(732, 21);
            this.numericUpDown_bearStart.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_bearStart.Name = "numericUpDown_bearStart";
            this.numericUpDown_bearStart.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown_bearStart.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(346, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "-";
            // 
            // numericUpDown_makeMoneyEnd
            // 
            this.numericUpDown_makeMoneyEnd.DecimalPlaces = 2;
            this.numericUpDown_makeMoneyEnd.Location = new System.Drawing.Point(366, 65);
            this.numericUpDown_makeMoneyEnd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_makeMoneyEnd.Name = "numericUpDown_makeMoneyEnd";
            this.numericUpDown_makeMoneyEnd.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown_makeMoneyEnd.TabIndex = 32;
            this.numericUpDown_makeMoneyEnd.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(216, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "掘金值：";
            // 
            // numericUpDown_makeMoneyStart
            // 
            this.numericUpDown_makeMoneyStart.DecimalPlaces = 2;
            this.numericUpDown_makeMoneyStart.Location = new System.Drawing.Point(275, 65);
            this.numericUpDown_makeMoneyStart.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_makeMoneyStart.Name = "numericUpDown_makeMoneyStart";
            this.numericUpDown_makeMoneyStart.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown_makeMoneyStart.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "-";
            // 
            // numericUpDown_bearNumEnd
            // 
            this.numericUpDown_bearNumEnd.Location = new System.Drawing.Point(151, 65);
            this.numericUpDown_bearNumEnd.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_bearNumEnd.Name = "numericUpDown_bearNumEnd";
            this.numericUpDown_bearNumEnd.Size = new System.Drawing.Size(41, 21);
            this.numericUpDown_bearNumEnd.TabIndex = 36;
            this.numericUpDown_bearNumEnd.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 35;
            this.label14.Text = "生育次数：";
            // 
            // numericUpDown_bearNumStart
            // 
            this.numericUpDown_bearNumStart.Location = new System.Drawing.Point(78, 65);
            this.numericUpDown_bearNumStart.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_bearNumStart.Name = "numericUpDown_bearNumStart";
            this.numericUpDown_bearNumStart.Size = new System.Drawing.Size(43, 21);
            this.numericUpDown_bearNumStart.TabIndex = 34;
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "id";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            this.编号.Width = 80;
            // 
            // 代数
            // 
            this.代数.DataPropertyName = "generation";
            this.代数.HeaderText = "代数";
            this.代数.Name = "代数";
            this.代数.Width = 70;
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "price";
            this.价格.HeaderText = "价格";
            this.价格.Name = "价格";
            this.价格.Width = 80;
            // 
            // 掘金分数
            // 
            this.掘金分数.DataPropertyName = "JueJinFenShu";
            this.掘金分数.HeaderText = "掘金分数";
            this.掘金分数.Name = "掘金分数";
            this.掘金分数.Width = 120;
            // 
            // 体重
            // 
            this.体重.DataPropertyName = "weight";
            this.体重.HeaderText = "体重";
            this.体重.Name = "体重";
            // 
            // 成长值
            // 
            this.成长值.DataPropertyName = "grow";
            this.成长值.HeaderText = "成长值";
            this.成长值.Name = "成长值";
            // 
            // 生育值
            // 
            this.生育值.DataPropertyName = "bear";
            this.生育值.HeaderText = "生育值";
            this.生育值.Name = "生育值";
            // 
            // 掘金值
            // 
            this.掘金值.DataPropertyName = "makemoney";
            this.掘金值.HeaderText = "掘金值";
            this.掘金值.Name = "掘金值";
            // 
            // 生育次数
            // 
            this.生育次数.DataPropertyName = "bearNum";
            this.生育次数.HeaderText = "生育次数";
            this.生育次数.Name = "生育次数";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.dataGridView_monkeys);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_genStart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_monkeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_genEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weightEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weightStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_growEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_growStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bearEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bearStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_makeMoneyEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_makeMoneyStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bearNumEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bearNumStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_generation;
        private System.Windows.Forms.NumericUpDown numericUpDown_genStart;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Timer timer_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_pages;
        private System.Windows.Forms.ComboBox comboBox_orderby;
        private System.Windows.Forms.DataGridView dataGridView_monkeys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_sort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_genEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_weightEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_weightStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_bearEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_bearStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_growEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_growStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_makeMoneyEnd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown_makeMoneyStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_bearNumEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown_bearNumStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 掘金分数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 体重;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成长值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生育值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 掘金值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生育次数;
    }
}