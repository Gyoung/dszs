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
            this.devType = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_AboutMe = new System.Windows.Forms.ToolStripMenuItem();
            this.lklQQ = new System.Windows.Forms.LinkLabel();
            this.lklEmail = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReceive = new System.Windows.Forms.TabPage();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Configer = new LeafSoft.Units.NetUDPServer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gvTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDevid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvValue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvValue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvNoise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCounter1 = new LeafSoft.Units.DataCounter();
            this.dataReceive1 = new LeafSoft.Units.DataReceive();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.devName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportTem = new System.Windows.Forms.Button();
            this.tabSender = new System.Windows.Forms.TabPage();
            this.udpClient = new LeafSoft.Units.NetUDPClient();
            this.btnSend = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ckLine = new System.Windows.Forms.CheckBox();
            this.bytesBox1 = new LeafSoft.LeafControl.BytesBox();
            this.MDataCounter = new LeafSoft.Units.DataCounter();
            this.DataReceiver = new LeafSoft.Units.DataReceive();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabReceive.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabSender.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devType,
            this.MS_AboutMe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // devType
            // 
            this.devType.Image = ((System.Drawing.Image)(resources.GetObject("devType.Image")));
            this.devType.Name = "devType";
            this.devType.Size = new System.Drawing.Size(108, 21);
            this.devType.Text = "新增设备类型";
            this.devType.Click += new System.EventHandler(this.devType_Click);
            // 
            // MS_AboutMe
            // 
            this.MS_AboutMe.Image = global::LeafSoft.Properties.Resources.leafsoft;
            this.MS_AboutMe.Name = "MS_AboutMe";
            this.MS_AboutMe.Size = new System.Drawing.Size(84, 21);
            this.MS_AboutMe.Text = "联系我们";
            this.MS_AboutMe.Click += new System.EventHandler(this.MS_AboutMe_Click_1);
            // 
            // lklQQ
            // 
            this.lklQQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lklQQ.AutoSize = true;
            this.lklQQ.BackColor = System.Drawing.Color.Transparent;
            this.lklQQ.Location = new System.Drawing.Point(996, 9);
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
            this.lklEmail.Location = new System.Drawing.Point(1019, 9);
            this.lklEmail.Name = "lklEmail";
            this.lklEmail.Size = new System.Drawing.Size(35, 12);
            this.lklEmail.TabIndex = 3;
            this.lklEmail.TabStop = true;
            this.lklEmail.Text = "Email";
            this.lklEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklEmail_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabReceive);
            this.tabControl1.Controls.Add(this.tabSender);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1057, 527);
            this.tabControl1.TabIndex = 4;
            // 
            // tabReceive
            // 
            this.tabReceive.Controls.Add(this.lblFile);
            this.tabReceive.Controls.Add(this.lblTip);
            this.tabReceive.Controls.Add(this.panel1);
            this.tabReceive.Controls.Add(this.Configer);
            this.tabReceive.Controls.Add(this.dataGridView1);
            this.tabReceive.Controls.Add(this.dataCounter1);
            this.tabReceive.Controls.Add(this.dataReceive1);
            this.tabReceive.Controls.Add(this.dataGridView2);
            this.tabReceive.Controls.Add(this.exportTem);
            this.tabReceive.Location = new System.Drawing.Point(4, 22);
            this.tabReceive.Name = "tabReceive";
            this.tabReceive.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceive.Size = new System.Drawing.Size(1049, 501);
            this.tabReceive.TabIndex = 1;
            this.tabReceive.Text = "数据展示平台";
            this.tabReceive.UseVisualStyleBackColor = true;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFile.Location = new System.Drawing.Point(691, 216);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 12);
            this.lblFile.TabIndex = 66;
            this.lblFile.DoubleClick += new System.EventHandler(this.lblFile_DoubleClick);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(580, 216);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(113, 12);
            this.lblTip.TabIndex = 65;
            this.lblTip.Text = "上次自动保存文件：";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(377, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 23);
            this.panel1.TabIndex = 64;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "清除展示数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "导出数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Configer
            // 
            this.Configer.AutoSize = true;
            this.Configer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Configer.Location = new System.Drawing.Point(9, 6);
            this.Configer.Name = "Configer";
            this.Configer.Size = new System.Drawing.Size(214, 203);
            this.Configer.TabIndex = 61;
            this.Configer.DataReceived += new LeafSoft.Lib.LeafEvent.DataReceivedHandler(this.Configer_DataReceived);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvTime,
            this.gvZone,
            this.gvDevid,
            this.gvType,
            this.gvAddress,
            this.gvValue1,
            this.gvValue2,
            this.gvSignal,
            this.gvNoise,
            this.gvStatus});
            this.dataGridView1.Location = new System.Drawing.Point(229, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(817, 235);
            this.dataGridView1.TabIndex = 43;
            // 
            // gvTime
            // 
            this.gvTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvTime.HeaderText = "时间";
            this.gvTime.Name = "gvTime";
            this.gvTime.ReadOnly = true;
            // 
            // gvZone
            // 
            this.gvZone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvZone.HeaderText = "区域地址";
            this.gvZone.Name = "gvZone";
            this.gvZone.ReadOnly = true;
            // 
            // gvDevid
            // 
            this.gvDevid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvDevid.HeaderText = "设备ID";
            this.gvDevid.Name = "gvDevid";
            this.gvDevid.ReadOnly = true;
            // 
            // gvType
            // 
            this.gvType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvType.HeaderText = "设备类型";
            this.gvType.Name = "gvType";
            this.gvType.ReadOnly = true;
            // 
            // gvAddress
            // 
            this.gvAddress.HeaderText = "设备地址";
            this.gvAddress.Name = "gvAddress";
            this.gvAddress.ReadOnly = true;
            this.gvAddress.Width = 90;
            // 
            // gvValue1
            // 
            this.gvValue1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvValue1.HeaderText = "数据1";
            this.gvValue1.Name = "gvValue1";
            this.gvValue1.ReadOnly = true;
            // 
            // gvValue2
            // 
            this.gvValue2.HeaderText = "数据2";
            this.gvValue2.Name = "gvValue2";
            this.gvValue2.ReadOnly = true;
            this.gvValue2.Width = 70;
            // 
            // gvSignal
            // 
            this.gvSignal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvSignal.DataPropertyName = "Signal ";
            this.gvSignal.HeaderText = "信号值";
            this.gvSignal.Name = "gvSignal";
            this.gvSignal.ReadOnly = true;
            // 
            // gvNoise
            // 
            this.gvNoise.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvNoise.HeaderText = "信噪比";
            this.gvNoise.Name = "gvNoise";
            this.gvNoise.ReadOnly = true;
            // 
            // gvStatus
            // 
            this.gvStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvStatus.HeaderText = "状态";
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.ReadOnly = true;
            // 
            // dataCounter1
            // 
            this.dataCounter1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCounter1.Location = new System.Drawing.Point(229, 213);
            this.dataCounter1.Name = "dataCounter1";
            this.dataCounter1.Size = new System.Drawing.Size(324, 22);
            this.dataCounter1.TabIndex = 42;
            // 
            // dataReceive1
            // 
            this.dataReceive1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataReceive1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataReceive1.Location = new System.Drawing.Point(229, 8);
            this.dataReceive1.Name = "dataReceive1";
            this.dataReceive1.Size = new System.Drawing.Size(812, 201);
            this.dataReceive1.TabIndex = 41;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devName});
            this.dataGridView2.Location = new System.Drawing.Point(9, 241);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(214, 235);
            this.dataGridView2.TabIndex = 40;
            // 
            // devName
            // 
            this.devName.HeaderText = "设备类型";
            this.devName.Name = "devName";
            this.devName.ReadOnly = true;
            this.devName.Width = 180;
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
            // tabSender
            // 
            this.tabSender.Controls.Add(this.udpClient);
            this.tabSender.Controls.Add(this.btnSend);
            this.tabSender.Controls.Add(this.radioButton1);
            this.tabSender.Controls.Add(this.radioButton2);
            this.tabSender.Controls.Add(this.ckLine);
            this.tabSender.Controls.Add(this.bytesBox1);
            this.tabSender.Controls.Add(this.MDataCounter);
            this.tabSender.Controls.Add(this.DataReceiver);
            this.tabSender.Location = new System.Drawing.Point(4, 22);
            this.tabSender.Name = "tabSender";
            this.tabSender.Padding = new System.Windows.Forms.Padding(3);
            this.tabSender.Size = new System.Drawing.Size(1027, 501);
            this.tabSender.TabIndex = 0;
            this.tabSender.Text = "发送设置区域";
            this.tabSender.UseVisualStyleBackColor = true;
            // 
            // udpClient
            // 
            this.udpClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.udpClient.Location = new System.Drawing.Point(6, 15);
            this.udpClient.Name = "udpClient";
            this.udpClient.Size = new System.Drawing.Size(203, 446);
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
            this.bytesBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bytesBox1.IsHex = LeafSoft.Lib.EnumType.CMDType.Hex;
            this.bytesBox1.Location = new System.Drawing.Point(423, 15);
            this.bytesBox1.Multiline = true;
            this.bytesBox1.Name = "bytesBox1";
            this.bytesBox1.Size = new System.Drawing.Size(580, 61);
            this.bytesBox1.TabIndex = 63;
            // 
            // MDataCounter
            // 
            this.MDataCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MDataCounter.Location = new System.Drawing.Point(445, 471);
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
            this.DataReceiver.Location = new System.Drawing.Point(234, 93);
            this.DataReceiver.Name = "DataReceiver";
            this.DataReceiver.Size = new System.Drawing.Size(769, 359);
            this.DataReceiver.TabIndex = 59;
            // 
            // yyzq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 552);
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
            this.tabReceive.ResumeLayout(false);
            this.tabReceive.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabSender.ResumeLayout(false);
            this.tabSender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.LinkLabel lklQQ;
        private System.Windows.Forms.LinkLabel lklEmail;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSender;
        private System.Windows.Forms.TabPage tabReceive;
        private Units.NetUDPClient udpClient;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox ckLine;
        private LeafControl.BytesBox bytesBox1;
        private Units.DataCounter MDataCounter;
        private Units.DataReceive DataReceiver;
        private System.Windows.Forms.Button exportTem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Units.DataReceive dataReceive1;
        private Units.DataCounter dataCounter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Units.NetUDPServer Configer;
        private System.Windows.Forms.ToolStripMenuItem devType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem MS_AboutMe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn devName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDevid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvValue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvValue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSignal;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvNoise;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvStatus;




    }
}

