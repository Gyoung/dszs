namespace LeafSoft.PartPanel
{
    partial class ComPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataReceiver = new LeafSoft.Units.DataReceive();
            this.MDataCounter = new LeafSoft.Units.DataCounter();
            this.DataSender = new LeafSoft.Units.DataSend();
            this.Configer = new LeafSoft.Units.NetRs232();
            this.basePanel1 = new LeafSoft.PartPanel.BasePanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.bytesBox1 = new LeafSoft.LeafControl.BytesBox();
            this.ckLine = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DataReceiver
            // 
            this.DataReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataReceiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataReceiver.Location = new System.Drawing.Point(0, 274);
            this.DataReceiver.Name = "DataReceiver";
            this.DataReceiver.Size = new System.Drawing.Size(800, 202);
            this.DataReceiver.TabIndex = 4;
            // 
            // MDataCounter
            // 
            this.MDataCounter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MDataCounter.Location = new System.Drawing.Point(0, 476);
            this.MDataCounter.Name = "MDataCounter";
            this.MDataCounter.Size = new System.Drawing.Size(800, 24);
            this.MDataCounter.TabIndex = 3;
            // 
            // DataSender
            // 
            this.DataSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSender.Location = new System.Drawing.Point(148, 0);
            this.DataSender.Name = "DataSender";
            this.DataSender.Size = new System.Drawing.Size(652, 211);
            this.DataSender.TabIndex = 2;
            this.DataSender.EventDataSend += new LeafSoft.Lib.LeafEvent.DataSendHandler(this.DataSender_EventDataSend);
            // 
            // Configer
            // 
            this.Configer.Location = new System.Drawing.Point(0, 2);
            this.Configer.Name = "Configer";
            this.Configer.Size = new System.Drawing.Size(151, 175);
            this.Configer.TabIndex = 1;
            this.Configer.DataReceived += new LeafSoft.Lib.LeafEvent.DataReceivedHandler(this.Configer_DataReceived);
            // 
            // basePanel1
            // 
            this.basePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.basePanel1.Location = new System.Drawing.Point(0, 209);
            this.basePanel1.Name = "basePanel1";
            this.basePanel1.Size = new System.Drawing.Size(800, 60);
            this.basePanel1.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(54, 218);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hex";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(53, 243);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "ASCII";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bytesBox1
            // 
            this.bytesBox1.IsHex = LeafSoft.Lib.EnumType.CMDType.Hex;
            this.bytesBox1.Location = new System.Drawing.Point(261, 220);
            this.bytesBox1.Multiline = true;
            this.bytesBox1.Name = "bytesBox1";
            this.bytesBox1.Size = new System.Drawing.Size(525, 37);
            this.bytesBox1.TabIndex = 9;
            // 
            // ckLine
            // 
            this.ckLine.AutoSize = true;
            this.ckLine.Location = new System.Drawing.Point(53, 183);
            this.ckLine.Name = "ckLine";
            this.ckLine.Size = new System.Drawing.Size(72, 16);
            this.ckLine.TabIndex = 10;
            this.ckLine.Text = "自动换行";
            this.ckLine.UseVisualStyleBackColor = true;
            // 
            // ComPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckLine);
            this.Controls.Add(this.bytesBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.basePanel1);
            this.Controls.Add(this.DataReceiver);
            this.Controls.Add(this.MDataCounter);
            this.Controls.Add(this.DataSender);
            this.Controls.Add(this.Configer);
            this.Name = "ComPanel";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Units.NetRs232 Configer;
        private Units.DataSend DataSender;
        private Units.DataCounter MDataCounter;
        private Units.DataReceive DataReceiver;
        private BasePanel basePanel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private LeafControl.BytesBox bytesBox1;
        private System.Windows.Forms.CheckBox ckLine;
    }
}
