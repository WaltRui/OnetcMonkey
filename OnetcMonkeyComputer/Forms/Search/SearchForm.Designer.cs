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
            this.label1 = new System.Windows.Forms.Label();
            this.label_generation = new System.Windows.Forms.Label();
            this.numericUpDown_generation = new System.Windows.Forms.NumericUpDown();
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
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.掘金分数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.体重 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成长值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生育值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.掘金值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生育次数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_generation)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_monkeys)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "代猴子";
            // 
            // label_generation
            // 
            this.label_generation.AutoSize = true;
            this.label_generation.Location = new System.Drawing.Point(133, 22);
            this.label_generation.Name = "label_generation";
            this.label_generation.Size = new System.Drawing.Size(17, 12);
            this.label_generation.TabIndex = 3;
            this.label_generation.Text = "第";
            // 
            // numericUpDown_generation
            // 
            this.numericUpDown_generation.Location = new System.Drawing.Point(172, 20);
            this.numericUpDown_generation.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_generation.Name = "numericUpDown_generation";
            this.numericUpDown_generation.Size = new System.Drawing.Size(62, 21);
            this.numericUpDown_generation.TabIndex = 1;
            this.numericUpDown_generation.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(365, 103);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 11;
            this.button_search.Text = "查找";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox_sort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_pages);
            this.groupBox1.Controls.Add(this.comboBox_orderby);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_generation);
            this.groupBox1.Controls.Add(this.numericUpDown_generation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 65);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "只";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "前";
            // 
            // checkBox_sort
            // 
            this.checkBox_sort.AutoSize = true;
            this.checkBox_sort.Location = new System.Drawing.Point(456, 21);
            this.checkBox_sort.Name = "checkBox_sort";
            this.checkBox_sort.Size = new System.Drawing.Size(48, 16);
            this.checkBox_sort.TabIndex = 13;
            this.checkBox_sort.Text = "倒序";
            this.checkBox_sort.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 22);
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
            this.comboBox_pages.Location = new System.Drawing.Point(577, 19);
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
            this.comboBox_orderby.Location = new System.Drawing.Point(353, 19);
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
            // 编号
            // 
            this.编号.DataPropertyName = "id";
            this.编号.HeaderText = "编号";
            this.编号.Name = "编号";
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "price";
            this.价格.HeaderText = "价格";
            this.价格.Name = "价格";
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_generation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_monkeys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_generation;
        private System.Windows.Forms.NumericUpDown numericUpDown_generation;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 掘金分数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 体重;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成长值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生育值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 掘金值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生育次数;
    }
}