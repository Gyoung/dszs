namespace LeafSoft
{
    partial class FrmShow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.区域地质 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数据 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tmpLow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmpHigh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exportTem = new System.Windows.Forms.Button();
            this.ckLine = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.udpClient = new LeafSoft.Units.NetUDPClient();
            this.bytesBox1 = new LeafSoft.LeafControl.BytesBox();
            this.basePanel1 = new LeafSoft.PartPanel.BasePanel();
            this.Configer = new LeafSoft.Units.NetUDPServer();
            this.MDataCounter = new LeafSoft.Units.DataCounter();
            this.DataReceiver = new LeafSoft.Units.DataReceive();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "展示区域";
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(636, 155);
            this.dataGridView1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "温度正常范围：";
            // 
            // tmpLow
            // 
            this.tmpLow.Location = new System.Drawing.Point(120, 495);
            this.tmpLow.Name = "tmpLow";
            this.tmpLow.Size = new System.Drawing.Size(41, 21);
            this.tmpLow.TabIndex = 30;
            this.tmpLow.Text = "-10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "~";
            // 
            // tmpHigh
            // 
            this.tmpHigh.Location = new System.Drawing.Point(187, 495);
            this.tmpHigh.Name = "tmpHigh";
            this.tmpHigh.Size = new System.Drawing.Size(42, 21);
            this.tmpHigh.TabIndex = 32;
            this.tmpHigh.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "℃";
            // 
            // exportTem
            // 
            this.exportTem.Location = new System.Drawing.Point(372, 489);
            this.exportTem.Name = "exportTem";
            this.exportTem.Size = new System.Drawing.Size(72, 23);
            this.exportTem.TabIndex = 38;
            this.exportTem.Text = "导出数据";
            this.exportTem.UseVisualStyleBackColor = true;
            this.exportTem.Click += new System.EventHandler(this.exportTem_Click);
            // 
            // ckLine
            // 
            this.ckLine.AutoSize = true;
            this.ckLine.Location = new System.Drawing.Point(238, 50);
            this.ckLine.Name = "ckLine";
            this.ckLine.Size = new System.Drawing.Size(72, 16);
            this.ckLine.TabIndex = 41;
            this.ckLine.Text = "自动换行";
            this.ckLine.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(300, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 16);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ASCII";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(300, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 16);
            this.radioButton1.TabIndex = 43;
            this.radioButton1.Text = "Hex";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(359, 29);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(62, 50);
            this.btnSend.TabIndex = 44;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "清除展示数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // udpClient
            // 
            this.udpClient.Location = new System.Drawing.Point(12, 3);
            this.udpClient.Name = "udpClient";
            this.udpClient.Size = new System.Drawing.Size(204, 166);
            this.udpClient.TabIndex = 58;
            // 
            // bytesBox1
            // 
            this.bytesBox1.IsHex = LeafSoft.Lib.EnumType.CMDType.Hex;
            this.bytesBox1.Location = new System.Drawing.Point(427, 18);
            this.bytesBox1.Multiline = true;
            this.bytesBox1.Name = "bytesBox1";
            this.bytesBox1.Size = new System.Drawing.Size(224, 61);
            this.bytesBox1.TabIndex = 40;
            // 
            // basePanel1
            // 
            this.basePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.basePanel1.Location = new System.Drawing.Point(232, 12);
            this.basePanel1.Name = "basePanel1";
            this.basePanel1.Size = new System.Drawing.Size(431, 78);
            this.basePanel1.TabIndex = 39;
            // 
            // Configer
            // 
            this.Configer.AutoSize = true;
            this.Configer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Configer.Location = new System.Drawing.Point(10, 175);
            this.Configer.Name = "Configer";
            this.Configer.Size = new System.Drawing.Size(214, 131);
            this.Configer.TabIndex = 8;
            this.Configer.DataReceived += new LeafSoft.Lib.LeafEvent.DataReceivedHandler(this.Configer_DataReceived);
            // 
            // MDataCounter
            // 
            this.MDataCounter.Location = new System.Drawing.Point(263, 282);
            this.MDataCounter.Name = "MDataCounter";
            this.MDataCounter.Size = new System.Drawing.Size(292, 24);
            this.MDataCounter.TabIndex = 37;
            // 
            // DataReceiver
            // 
            this.DataReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataReceiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataReceiver.Location = new System.Drawing.Point(232, 96);
            this.DataReceiver.Name = "DataReceiver";
            this.DataReceiver.Size = new System.Drawing.Size(431, 180);
            this.DataReceiver.TabIndex = 5;
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 519);
            this.Controls.Add(this.udpClient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.ckLine);
            this.Controls.Add(this.bytesBox1);
            this.Controls.Add(this.basePanel1);
            this.Controls.Add(this.Configer);
            this.Controls.Add(this.MDataCounter);
            this.Controls.Add(this.exportTem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tmpHigh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tmpLow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataReceiver);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmShow";
            this.Text = "数据展示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmShow_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Units.DataReceive DataReceiver;
        private Units.NetUDPServer Configer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tmpLow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tmpHigh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exportTem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 区域地质;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数据;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private Units.DataCounter MDataCounter;
        private PartPanel.BasePanel basePanel1;
        private LeafControl.BytesBox bytesBox1;
        private System.Windows.Forms.CheckBox ckLine;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button2;
        private Units.NetUDPClient udpClient;
    }
}