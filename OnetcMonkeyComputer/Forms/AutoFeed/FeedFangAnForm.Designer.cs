namespace OnetcMonkeyComputer.Forms.AutoFeed
{
    partial class FeedFangAnForm
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
            this.comboBox_fangan = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Id = new System.Windows.Forms.NumericUpDown();
            this.label_result = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_fangan
            // 
            this.comboBox_fangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fangan.FormattingEnabled = true;
            this.comboBox_fangan.Items.AddRange(new object[] {
            "最大投食方案",
            "至少一次投食大于1",
            "至少两次投食大于1",
            "至少三次投食大于1",
            "至少四次投食大于1"});
            this.comboBox_fangan.Location = new System.Drawing.Point(270, 59);
            this.comboBox_fangan.Name = "comboBox_fangan";
            this.comboBox_fangan.Size = new System.Drawing.Size(157, 20);
            this.comboBox_fangan.TabIndex = 10;
            this.comboBox_fangan.SelectedIndexChanged += new System.EventHandler(this.comboBox_fangan_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(14, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(476, 212);
            this.listBox1.TabIndex = 8;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "猴子编号：";
            // 
            // numericUpDown_Id
            // 
            this.numericUpDown_Id.Location = new System.Drawing.Point(127, 58);
            this.numericUpDown_Id.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_Id.Name = "numericUpDown_Id";
            this.numericUpDown_Id.ReadOnly = true;
            this.numericUpDown_Id.Size = new System.Drawing.Size(85, 21);
            this.numericUpDown_Id.TabIndex = 7;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(12, 96);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 12);
            this.label_result.TabIndex = 11;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(352, 364);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 12;
            this.button_ok.Text = "确定";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(214, 364);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 13;
            this.button_del.Text = "删除";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(76, 364);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 14;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // FeedFangAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 409);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.comboBox_fangan);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeedFangAnForm";
            this.Text = "FeedFangAnForm";
            this.Load += new System.EventHandler(this.FeedFangAnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_fangan;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Id;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_cancel;
    }
}