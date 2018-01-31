namespace OnetcMonkeyComputer.Forms.Calculators
{
    partial class PanTaoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.体重 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.今日已喂 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.启用自动喂食 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.喂食方案 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总计喂食 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手续费 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总费用 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(111, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "高代猴子喂养计算器";
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
            this.今日已喂,
            this.启用自动喂食,
            this.喂食方案,
            this.总计喂食,
            this.手续费,
            this.总费用,
            this.操作});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(928, 479);
            this.dataGridView1.TabIndex = 1;
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
            // 操作
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "双击进行配置";
            this.操作.DefaultCellStyle = dataGridViewCellStyle1;
            this.操作.HeaderText = "操作";
            this.操作.Name = "操作";
            this.操作.ReadOnly = true;
            this.操作.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.操作.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.操作.Text = "";
            this.操作.Width = 120;
            // 
            // PanTaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanTaoForm";
            this.Text = "PanTaoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 体重;
        private System.Windows.Forms.DataGridViewTextBoxColumn 今日已喂;
        private System.Windows.Forms.DataGridViewTextBoxColumn 启用自动喂食;
        private System.Windows.Forms.DataGridViewTextBoxColumn 喂食方案;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总计喂食;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手续费;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总费用;
        private System.Windows.Forms.DataGridViewButtonColumn 操作;
    }
}