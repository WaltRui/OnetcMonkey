namespace OnetcMonkeyComputer.Forms.AutoXiulian
{
    partial class AutoXiulianForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.体重 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最低属性 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最低属性值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已修炼 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修炼法门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修炼次数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总费用 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_step2_pre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_step2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_step3_pre = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_log = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_feedwallet = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_dashang = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label23);
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
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(581, 12);
            this.label23.TabIndex = 12;
            this.label23.Text = "软件虽然可获取今日已修炼数量，但并不做判断，所以，修炼限额需要自己把握，切勿对同一猴子修炼超过50";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(305, 12);
            this.label22.TabIndex = 11;
            this.label22.Text = "当前只支持对同一只猴子配置一种修炼法门（修炼消耗）";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(149, 12);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(35, 12);
            this.label_count.TabIndex = 10;
            this.label_count.Text = "共0只";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "双击猴子可进行配置自动修炼方案。配置完成后点击下一步";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(788, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "下一步";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_reload
            // 
            this.button_reload.Location = new System.Drawing.Point(528, 31);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(75, 23);
            this.button_reload.TabIndex = 7;
            this.button_reload.Text = "刷新";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "你的所有猴子如下列表：";
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
            this.最低属性,
            this.最低属性值,
            this.已修炼,
            this.修炼法门,
            this.修炼次数,
            this.总费用});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(914, 452);
            this.dataGridView1.TabIndex = 1;
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
            // 最低属性
            // 
            this.最低属性.DataPropertyName = "MinProperty";
            this.最低属性.HeaderText = "最低属性";
            this.最低属性.Name = "最低属性";
            this.最低属性.ReadOnly = true;
            // 
            // 最低属性值
            // 
            this.最低属性值.DataPropertyName = "MinPropertyValue";
            this.最低属性值.HeaderText = "最低属性值";
            this.最低属性值.Name = "最低属性值";
            this.最低属性值.ReadOnly = true;
            // 
            // 已修炼
            // 
            this.已修炼.DataPropertyName = "XiuLianToday";
            this.已修炼.HeaderText = "今日已修炼";
            this.已修炼.Name = "已修炼";
            this.已修炼.ReadOnly = true;
            // 
            // 修炼法门
            // 
            this.修炼法门.DataPropertyName = "Des";
            this.修炼法门.HeaderText = "修炼法门";
            this.修炼法门.Name = "修炼法门";
            this.修炼法门.ReadOnly = true;
            this.修炼法门.Width = 210;
            // 
            // 修炼次数
            // 
            this.修炼次数.DataPropertyName = "Time";
            this.修炼次数.HeaderText = "修炼次数";
            this.修炼次数.Name = "修炼次数";
            this.修炼次数.ReadOnly = true;
            this.修炼次数.Width = 90;
            // 
            // 总费用
            // 
            this.总费用.DataPropertyName = "Cost";
            this.总费用.HeaderText = "总费用";
            this.总费用.Name = "总费用";
            this.总费用.ReadOnly = true;
            this.总费用.Width = 90;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
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
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(50, 522);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(527, 12);
            this.label21.TabIndex = 27;
            this.label21.Text = "3、软件使用过程中，因电脑卡顿造成喂食失败等情况，软件作者不负任何责任，不认同，请返回。";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(50, 482);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(419, 12);
            this.label20.TabIndex = 26;
            this.label20.Text = "4、为防止有人将软件绑马，请从软件官网或软件作者共享在群里的文件下载。";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(50, 442);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(431, 12);
            this.label17.TabIndex = 25;
            this.label17.Text = "3、软件需要填写链克钱包密码，密码仅在你自己电脑上使用，不会上传和他用。";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 403);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(443, 12);
            this.label18.TabIndex = 24;
            this.label18.Text = "2、为了防止软件转账出错，软件自动检测了转账金额，确保修炼过程转账不大于50";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(50, 366);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(515, 12);
            this.label19.TabIndex = 23;
            this.label19.Text = "1、本软件目前只经过作者本人在自己电脑上测试通过。当然，使用过程中，我会根据反馈完善。";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(48, 326);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 21);
            this.label16.TabIndex = 22;
            this.label16.Text = "风险预告：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(335, 12);
            this.label15.TabIndex = 21;
            this.label15.Text = "3、为保证软件正常运行，修炼过程中，请不要操作鼠标和键盘";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(443, 12);
            this.label14.TabIndex = 20;
            this.label14.Text = "2、下一步中要填写的钱包地址为喂养猴子的系统钱包地址，并非你自己的钱包地址";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(479, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "1、将链克钱包打开，并点击用来修炼猴子的账号，将其置前。并保证右侧滚动条在最上方";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(48, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "使用方法：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_step2_pre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_step2);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 97);
            this.groupBox1.TabIndex = 17;
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
            this.tabPage3.Controls.Add(this.button_step3_pre);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.listBox_log);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox_pwd);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBox_feedwallet);
            this.tabPage3.Controls.Add(this.button_start);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(920, 558);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_step3_pre
            // 
            this.button_step3_pre.Location = new System.Drawing.Point(815, 116);
            this.button_step3_pre.Name = "button_step3_pre";
            this.button_step3_pre.Size = new System.Drawing.Size(75, 23);
            this.button_step3_pre.TabIndex = 25;
            this.button_step3_pre.Text = "返回上一步";
            this.button_step3_pre.UseVisualStyleBackColor = false;
            this.button_step3_pre.Click += new System.EventHandler(this.button_step3_pre_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(142, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(216, 16);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "我已阅读使用教程，并了解相关风险";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(47, 121);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "使用教程";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "此为玩客猴官方的系统钱包，并非你的个人钱包";
            // 
            // listBox_log
            // 
            this.listBox_log.FormattingEnabled = true;
            this.listBox_log.ItemHeight = 12;
            this.listBox_log.Location = new System.Drawing.Point(7, 170);
            this.listBox_log.Name = "listBox_log";
            this.listBox_log.Size = new System.Drawing.Size(906, 364);
            this.listBox_log.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "你的钱包密码：";
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(142, 70);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.Size = new System.Drawing.Size(447, 21);
            this.textBox_pwd.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "修炼系统钱包：";
            // 
            // textBox_feedwallet
            // 
            this.textBox_feedwallet.Location = new System.Drawing.Point(142, 24);
            this.textBox_feedwallet.Name = "textBox_feedwallet";
            this.textBox_feedwallet.Size = new System.Drawing.Size(447, 21);
            this.textBox_feedwallet.TabIndex = 17;
            this.textBox_feedwallet.Text = "0x0a4d16e66e1939639f8a4ba6f92b67bccfe20d62";
            // 
            // button_start
            // 
            this.button_start.Enabled = false;
            this.button_start.Location = new System.Drawing.Point(436, 113);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 16;
            this.button_start.Text = "开始修炼";
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
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(8, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 182);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(87, 94);
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
            this.label7.Location = new System.Drawing.Point(90, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "本软件完全免费。请勿将此软件倒卖、商用。";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button_dashang);
            this.groupBox2.Controls.Add(this.button_return);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(8, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 337);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "打赏";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(90, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "打赏全凭自愿，不打赏软件一样使用";
            // 
            // button_dashang
            // 
            this.button_dashang.Location = new System.Drawing.Point(560, 124);
            this.button_dashang.Name = "button_dashang";
            this.button_dashang.Size = new System.Drawing.Size(75, 23);
            this.button_dashang.TabIndex = 6;
            this.button_dashang.Text = "打赏";
            this.button_dashang.UseVisualStyleBackColor = true;
            this.button_dashang.Click += new System.EventHandler(this.button_dashang_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(214, 124);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 5;
            this.button_return.Text = "返回";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "链克";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "选择打赏金额：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(422, 46);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 21);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // AutoXiulianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoXiulianForm";
            this.Text = "AutoXiulianForm";
            this.Load += new System.EventHandler(this.AutoXiulianForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_step2_pre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_step2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_feedwallet;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_dashang;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 体重;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最低属性;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最低属性值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已修炼;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修炼法门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修炼次数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总费用;
        private System.Windows.Forms.Button button_step3_pre;
    }
}