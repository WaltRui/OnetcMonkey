namespace OnetcMonkeyComputer.Forms.Overview
{
    partial class OverViewForm
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
            this.dataGridView_overview = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.掘金池总额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.掘金分总额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.comboBox_datatype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_overview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_overview
            // 
            this.dataGridView_overview.AllowUserToAddRows = false;
            this.dataGridView_overview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_overview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Trade,
            this.Bear,
            this.Feed,
            this.Game,
            this.Sale,
            this.Description,
            this.掘金池总额,
            this.掘金分总额});
            this.dataGridView_overview.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_overview.Name = "dataGridView_overview";
            this.dataGridView_overview.ReadOnly = true;
            this.dataGridView_overview.RowTemplate.Height = 23;
            this.dataGridView_overview.Size = new System.Drawing.Size(904, 298);
            this.dataGridView_overview.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "日期";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Trade
            // 
            this.Trade.DataPropertyName = "Trade";
            this.Trade.HeaderText = "交易金额";
            this.Trade.Name = "Trade";
            this.Trade.ReadOnly = true;
            this.Trade.Width = 80;
            // 
            // Bear
            // 
            this.Bear.DataPropertyName = "Bear";
            this.Bear.HeaderText = "生育金额";
            this.Bear.Name = "Bear";
            this.Bear.ReadOnly = true;
            this.Bear.Width = 80;
            // 
            // Feed
            // 
            this.Feed.DataPropertyName = "Feed";
            this.Feed.HeaderText = "投食金额";
            this.Feed.Name = "Feed";
            this.Feed.ReadOnly = true;
            this.Feed.Width = 80;
            // 
            // Game
            // 
            this.Game.DataPropertyName = "Game";
            this.Game.HeaderText = "抽奖金额";
            this.Game.Name = "Game";
            this.Game.ReadOnly = true;
            this.Game.Width = 80;
            // 
            // Sale
            // 
            this.Sale.DataPropertyName = "Sale";
            this.Sale.HeaderText = "拍卖金额";
            this.Sale.Name = "Sale";
            this.Sale.ReadOnly = true;
            this.Sale.Width = 80;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "掘金池来源";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 170;
            // 
            // 掘金池总额
            // 
            this.掘金池总额.DataPropertyName = "AllMakeMoney";
            this.掘金池总额.HeaderText = "掘金池总额";
            this.掘金池总额.Name = "掘金池总额";
            this.掘金池总额.ReadOnly = true;
            // 
            // 掘金分总额
            // 
            this.掘金分总额.DataPropertyName = "AllMakeMoneyScore";
            this.掘金分总额.HeaderText = "掘金分总额";
            this.掘金分总额.Name = "掘金分总额";
            this.掘金分总额.ReadOnly = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 348);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(904, 236);
            this.zedGraphControl1.TabIndex = 1;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // comboBox_datatype
            // 
            this.comboBox_datatype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_datatype.FormattingEnabled = true;
            this.comboBox_datatype.Items.AddRange(new object[] {
            "掘金池总额",
            "掘金分数总额",
            "交易金额",
            "生育金额",
            "投食金额"});
            this.comboBox_datatype.Location = new System.Drawing.Point(189, 322);
            this.comboBox_datatype.Name = "comboBox_datatype";
            this.comboBox_datatype.Size = new System.Drawing.Size(121, 20);
            this.comboBox_datatype.TabIndex = 2;
            this.comboBox_datatype.SelectedIndexChanged += new System.EventHandler(this.comboBox_datatype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "查看";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "走势";
            // 
            // OverViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_datatype);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.dataGridView_overview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverViewForm";
            this.Text = "OverViewForm";
            this.Load += new System.EventHandler(this.OverViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_overview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_overview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Game;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn 掘金池总额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 掘金分总额;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ComboBox comboBox_datatype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}