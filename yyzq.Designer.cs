namespace LeafSoft
{
    partial class yyzq
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yyzq));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Bytes = new System.Windows.Forms.ToolStripMenuItem();
            this.数据展示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lklQQ = new System.Windows.Forms.LinkLabel();
            this.lklEmail = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSender = new System.Windows.Forms.TabPage();
            this.udpClient = new LeafSoft.Units.NetUDPClient();
            this.btnSend = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ckLine = new System.Windows.Forms.CheckBox();
            this.bytesBox1 = new LeafSoft.LeafControl.BytesBox();
            this.basePanel1 = new LeafSoft.PartPanel.BasePanel();
            this.MDataCounter = new LeafSoft.Units.DataCounter();
            this.DataReceiver = new LeafSoft.Units.DataReceive();
            this.tabReceive = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.区域地质 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数据 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCounter1 = new LeafSoft.Units.DataCounter();
            this.dataReceive1 = new LeafSoft.Units.DataReceive();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportTem = new System.Windows.Forms.Button();
            this.Configer = new LeafSoft.Units.NetUDPServer();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSender.SuspendLayout();
            this.tabReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算器ToolStripMenuItem,
            this.数据展示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Check,
            this.MS_Bytes});
            this.计算器ToolStripMenuItem.Image = global::LeafSoft.Properties.Resources.hex;
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.计算器ToolStripMenuItem.Text = "计算器";
            // 
            // MS_Check
            // 
            this.MS_Check.Image = global::LeafSoft.Properties.Resources.hex;
            this.MS_Check.Name = "MS_Check";
            this.MS_Check.Size = new System.Drawing.Size(148, 22);
            this.MS_Check.Text = "校验码计算器";
            this.MS_Check.Click += new System.EventHandler(this.MS_Check_Click);
            // 
            // MS_Bytes
            // 
            this.MS_Bytes.Image = global::LeafSoft.Properties.Resources.calculator;
            this.MS_Bytes.Name = "MS_Bytes";
            this.MS_Bytes.Size = new System.Drawing.Size(148, 22);
            this.MS_Bytes.Text = "数值计算器";
            this.MS_Bytes.Click += new System.EventHandler(this.MS_Bytes_Click);
            // 
            // 数据展示ToolStripMenuItem
            // 
            this.数据展示ToolStripMenuItem.Name = "数据展示ToolStripMenuItem";
            this.数据展示ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据展示ToolStripMenuItem.Text = "数据展示";
            this.数据展示ToolStripMenuItem.Click += new System.EventHandler(this.数据展示ToolStripMenuItem_Click);
            // 
            // lklQQ
            // 
            this.lklQQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lklQQ.AutoSize = true;
            this.lklQQ.BackColor = System.Drawing.Color.Transparent;
            this.lklQQ.Location = new System.Drawing.Point(783, 9);
            this.lklQQ.Name = "lklQQ";
            this.lklQQ.Size = new System.Drawing.Size(17, 12);
            this.lklQQ.TabIndex = 2;
            this.lklQQ.TabStop = true;
            this.lklQQ.Text = "QQ";
            this.lklQQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklQQ_LinkClicked);
            // 
            // lklEmail
            // 
            this.lklEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lklEmail.AutoSize = true;
            this.lklEmail.BackColor = System.Drawing.Color.Transparent;
            this.lklEmail.Location = new System.Drawing.Point(806, 9);
            this.lklEmail.Name = "lklEmail";
            this.lklEmail.Size = new System.Drawing.Size(35, 12);
            this.lklEmail.TabIndex = 3;
            this.lklEmail.TabStop = true;
            this.lklEmail.Text = "Email";
            this.lklEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklEmail_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReceive);
            this.tabControl1.Controls.Add(this.tabSender);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 527);
            this.tabControl1.TabIndex = 4;
            // 
            // tabSender
            // 
            this.tabSender.Controls.Add(this.udpClient);
            this.tabSender.Controls.Add(this.btnSend);
            this.tabSender.Controls.Add(this.radioButton1);
            this.tabSender.Controls.Add(this.radioButton2);
            this.tabSender.Controls.Add(this.ckLine);
            this.tabSender.Controls.Add(this.bytesBox1);
            this.tabSender.Controls.Add(this.basePanel1);
            this.tabSender.Controls.Add(this.MDataCounter);
            this.tabSender.Controls.Add(this.DataReceiver);
            this.tabSender.Location = new System.Drawing.Point(4, 22);
            this.tabSender.Name = "tabSender";
            this.tabSender.Padding = new System.Windows.Forms.Padding(3);
            this.tabSender.Size = new System.Drawing.Size(836, 501);
            this.tabSender.TabIndex = 0;
            this.tabSender.Text = "发送端";
            this.tabSender.UseVisualStyleBackColor = true;
            // 
            // udpClient
            // 
            this.udpClient.Location = new System.Drawing.Point(6, 15);
            this.udpClient.Name = "udpClient";
            this.udpClient.Size = new System.Drawing.Size(204, 166);
            this.udpClient.TabIndex = 68;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(355, 26);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(62, 50);
            this.btnSend.TabIndex = 67;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(296, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 16);
            this.radioButton1.TabIndex = 66;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hex";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(296, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 16);
            this.radioButton2.TabIndex = 65;
            this.radioButton2.Text = "ASCII";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ckLine
            // 
            this.ckLine.AutoSize = true;
            this.ckLine.Location = new System.Drawing.Point(234, 47);
            this.ckLine.Name = "ckLine";
            this.ckLine.Size = new System.Drawing.Size(72, 16);
            this.ckLine.TabIndex = 64;
            this.ckLine.Text = "自动换行";
            this.ckLine.UseVisualStyleBackColor = true;
            // 
            // bytesBox1
            // 
            this.bytesBox1.IsHex = LeafSoft.Lib.EnumType.CMDType.Hex;
            this.bytesBox1.Location = new System.Drawing.Point(423, 15);
            this.bytesBox1.Multiline = true;
            this.bytesBox1.Name = "bytesBox1";
            this.bytesBox1.Size = new System.Drawing.Size(401, 61);
            this.bytesBox1.TabIndex = 63;
            // 
            // basePanel1
            // 
            this.basePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.basePanel1.Location = new System.Drawing.Point(228, 9);
            this.basePanel1.Name = "basePanel1";
            this.basePanel1.Size = new System.Drawing.Size(596, 78);
            this.basePanel1.TabIndex = 62;
            // 
            // MDataCounter
            // 
            this.MDataCounter.Location = new System.Drawing.Point(228, 469);
            this.MDataCounter.Name = "MDataCounter";
            this.MDataCounter.Size = new System.Drawing.Size(292, 24);
            this.MDataCounter.TabIndex = 61;
            // 
            // DataReceiver
            // 
            this.DataReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataReceiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataReceiver.Location = new System.Drawing.Point(228, 93);
            this.DataReceiver.Name = "DataReceiver";
            this.DataReceiver.Size = new System.Drawing.Size(596, 370);
            this.DataReceiver.TabIndex = 59;
            // 
            // tabReceive
            // 
            this.tabReceive.Controls.Add(this.Configer);
            this.tabReceive.Controls.Add(this.dataGridView1);
            this.tabReceive.Controls.Add(this.dataCounter1);
            this.tabReceive.Controls.Add(this.dataReceive1);
            this.tabReceive.Controls.Add(this.dataGridView2);
            this.tabReceive.Controls.Add(this.exportTem);
            this.tabReceive.Location = new System.Drawing.Point(4, 22);
            this.tabReceive.Name = "tabReceive";
            this.tabReceive.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceive.Size = new System.Drawing.Size(836, 501);
            this.tabReceive.TabIndex = 1;
            this.tabReceive.Text = "接受端";
            this.tabReceive.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.时间,
            this.区域地质,
            this.设备ID,
            this.设备类型,
            this.数据,
            this.状态});
            this.dataGridView1.Location = new System.Drawing.Point(229, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(599, 233);
            this.dataGridView1.TabIndex = 43;
            // 
            // 时间
            // 
            this.时间.DataPropertyName = "CreateTime";
            this.时间.HeaderText = "时间";
            this.时间.Name = "时间";
            this.时间.Width = 120;
            // 
            // 区域地质
            // 
            this.区域地质.DataPropertyName = "ZoneId";
            this.区域地质.HeaderText = "区域地址";
            this.区域地质.Name = "区域地质";
            this.区域地质.Width = 80;
            // 
            // 设备ID
            // 
            this.设备ID.DataPropertyName = "DeviceId";
            this.设备ID.HeaderText = "设备ID";
            this.设备ID.Name = "设备ID";
            this.设备ID.Width = 80;
            // 
            // 设备类型
            // 
            this.设备类型.DataPropertyName = "Type";
            this.设备类型.HeaderText = "设备类型";
            this.设备类型.Name = "设备类型";
            // 
            // 数据
            // 
            this.数据.DataPropertyName = "Value1";
            this.数据.HeaderText = "数据";
            this.数据.Name = "数据";
            this.数据.Width = 160;
            // 
            // 状态
            // 
            this.状态.DataPropertyName = "Status";
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.Width = 60;
            // 
            // dataCounter1
            // 
            this.dataCounter1.Location = new System.Drawing.Point(6, 450);
            this.dataCounter1.Name = "dataCounter1";
            this.dataCounter1.Size = new System.Drawing.Size(292, 24);
            this.dataCounter1.TabIndex = 42;
            // 
            // dataReceive1
            // 
            this.dataReceive1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataReceive1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataReceive1.Location = new System.Drawing.Point(229, 6);
            this.dataReceive1.Name = "dataReceive1";
            this.dataReceive1.Size = new System.Drawing.Size(599, 199);
            this.dataReceive1.TabIndex = 41;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(3, 211);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(220, 233);
            this.dataGridView2.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "设备类型";
            this.Column1.Name = "Column1";
            // 
            // exportTem
            // 
            this.exportTem.Location = new System.Drawing.Point(403, 324);
            this.exportTem.Name = "exportTem";
            this.exportTem.Size = new System.Drawing.Size(72, 23);
            this.exportTem.TabIndex = 39;
            this.exportTem.Text = "导出数据";
            this.exportTem.UseVisualStyleBackColor = true;
            // 
            // Configer
            // 
            this.Configer.AutoSize = true;
            this.Configer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Configer.Location = new System.Drawing.Point(9, 6);
            this.Configer.Name = "Configer";
            this.Configer.Size = new System.Drawing.Size(214, 191);
            this.Configer.TabIndex = 61;
            this.Configer.DataReceived += new LeafSoft.Lib.LeafEvent.DataReceivedHandler(this.Configer_DataReceived);
            // 
            // yyzq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 552);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lklEmail);
            this.Controls.Add(this.lklQQ);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "yyzq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.yyzq_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSender.ResumeLayout(false);
            this.tabSender.PerformLayout();
            this.tabReceive.ResumeLayout(false);
            this.tabReceive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MS_Check;
        private System.Windows.Forms.LinkLabel lklQQ;
        private System.Windows.Forms.LinkLabel lklEmail;
        private System.Windows.Forms.ToolStripMenuItem MS_Bytes;
        private System.Windows.Forms.ToolStripMenuItem 数据展示ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSender;
        private System.Windows.Forms.TabPage tabReceive;
        private Units.NetUDPClient udpClient;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox ckLine;
        private LeafControl.BytesBox bytesBox1;
        private PartPanel.BasePanel basePanel1;
        private Units.DataCounter MDataCounter;
        private Units.DataReceive DataReceiver;
        private System.Windows.Forms.Button exportTem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Units.DataReceive dataReceive1;
        private Units.DataCounter dataCounter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 区域地质;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数据;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private Units.NetUDPServer Configer;




    }
}

