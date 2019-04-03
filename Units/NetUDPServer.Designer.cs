﻿namespace LeafSoft.Units
{
    partial class NetUDPServer
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
            this.components = new System.ComponentModel.Container();
            this.btnListen = new System.Windows.Forms.Button();
            this.cbxLocalIP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstConn = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.nmLocalPort = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(100, 29);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(55, 23);
            this.btnListen.TabIndex = 10;
            this.btnListen.Text = "监听";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // cbxLocalIP
            // 
            this.cbxLocalIP.FormattingEnabled = true;
            this.cbxLocalIP.Items.AddRange(new object[] {
            "Any"});
            this.cbxLocalIP.Location = new System.Drawing.Point(36, 4);
            this.cbxLocalIP.Name = "cbxLocalIP";
            this.cbxLocalIP.Size = new System.Drawing.Size(119, 20);
            this.cbxLocalIP.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "本地";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "端口";
            // 
            // lstConn
            // 
            this.lstConn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstConn.ContextMenuStrip = this.contextMenuStrip1;
            this.lstConn.FormattingEnabled = true;
            this.lstConn.ItemHeight = 12;
            this.lstConn.Location = new System.Drawing.Point(0, 91);
            this.lstConn.Name = "lstConn";
            this.lstConn.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstConn.Size = new System.Drawing.Size(155, 88);
            this.lstConn.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // MS_Delete
            // 
            this.MS_Delete.Name = "MS_Delete";
            this.MS_Delete.Size = new System.Drawing.Size(100, 22);
            this.MS_Delete.Text = "删除";
            this.MS_Delete.Click += new System.EventHandler(this.MS_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "地址";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(36, 65);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(0, 12);
            this.lbLocation.TabIndex = 13;
            // 
            // nmLocalPort
            // 
            this.nmLocalPort.FormattingEnabled = true;
            this.nmLocalPort.Location = new System.Drawing.Point(36, 31);
            this.nmLocalPort.Name = "nmLocalPort";
            this.nmLocalPort.Size = new System.Drawing.Size(58, 20);
            this.nmLocalPort.TabIndex = 14;
            this.nmLocalPort.SelectedIndexChanged += new System.EventHandler(this.nmLocalPort_SelectedIndexChanged);
            // 
            // NetUDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.nmLocalPort);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstConn);
            this.Controls.Add(this.cbxLocalIP);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "NetUDPServer";
            this.Size = new System.Drawing.Size(160, 203);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ComboBox cbxLocalIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstConn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.ComboBox nmLocalPort;

    }
}
