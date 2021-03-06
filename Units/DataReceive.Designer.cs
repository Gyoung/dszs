﻿namespace LeafSoft.Units
{
    partial class DataReceive
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.CMS_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToInt = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToDouble = new System.Windows.Forms.ToolStripMenuItem();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.rbtnASCII = new System.Windows.Forms.RadioButton();
            this.ckTimestamp = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CMS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.ContextMenuStrip = this.CMS_Main;
            this.txtData.Location = new System.Drawing.Point(0, 24);
            this.txtData.MaxLength = 1;
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(523, 182);
            this.txtData.TabIndex = 1;
            // 
            // CMS_Main
            // 
            this.CMS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Clear,
            this.MS_ToInt,
            this.MS_ToFloat,
            this.MS_ToDouble});
            this.CMS_Main.Name = "contextMenuStrip1";
            this.CMS_Main.ShowImageMargin = false;
            this.CMS_Main.Size = new System.Drawing.Size(174, 92);
            this.CMS_Main.VisibleChanged += new System.EventHandler(this.CMS_Main_VisibleChanged);
            // 
            // MS_Clear
            // 
            this.MS_Clear.Name = "MS_Clear";
            this.MS_Clear.Size = new System.Drawing.Size(173, 22);
            this.MS_Clear.Text = "清空";
            this.MS_Clear.Click += new System.EventHandler(this.MS_Clear_Click);
            // 
            // MS_ToInt
            // 
            this.MS_ToInt.Name = "MS_ToInt";
            this.MS_ToInt.Size = new System.Drawing.Size(173, 22);
            this.MS_ToInt.Text = "转换为整数(Int)";
            this.MS_ToInt.Click += new System.EventHandler(this.MS_ToInt_Click);
            // 
            // MS_ToFloat
            // 
            this.MS_ToFloat.Name = "MS_ToFloat";
            this.MS_ToFloat.Size = new System.Drawing.Size(173, 22);
            this.MS_ToFloat.Text = "转换为浮点数(Float)";
            this.MS_ToFloat.Click += new System.EventHandler(this.MS_ToFloat_Click);
            // 
            // MS_ToDouble
            // 
            this.MS_ToDouble.Name = "MS_ToDouble";
            this.MS_ToDouble.Size = new System.Drawing.Size(173, 22);
            this.MS_ToDouble.Text = "转换为浮点数(Double)";
            this.MS_ToDouble.Click += new System.EventHandler(this.MS_ToDouble_Click);
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Location = new System.Drawing.Point(70, 4);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnHex.TabIndex = 3;
            this.rbtnHex.Text = "Hex";
            this.rbtnHex.UseVisualStyleBackColor = true;
            // 
            // rbtnASCII
            // 
            this.rbtnASCII.AutoSize = true;
            this.rbtnASCII.Checked = true;
            this.rbtnASCII.Location = new System.Drawing.Point(116, 4);
            this.rbtnASCII.Name = "rbtnASCII";
            this.rbtnASCII.Size = new System.Drawing.Size(53, 16);
            this.rbtnASCII.TabIndex = 4;
            this.rbtnASCII.TabStop = true;
            this.rbtnASCII.Text = "ASCII";
            this.rbtnASCII.UseVisualStyleBackColor = true;
            // 
            // ckTimestamp
            // 
            this.ckTimestamp.AutoSize = true;
            this.ckTimestamp.Checked = true;
            this.ckTimestamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTimestamp.Location = new System.Drawing.Point(3, 4);
            this.ckTimestamp.Name = "ckTimestamp";
            this.ckTimestamp.Size = new System.Drawing.Size(60, 16);
            this.ckTimestamp.TabIndex = 2;
            this.ckTimestamp.Text = "时间戳";
            this.ckTimestamp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.rbtnASCII);
            this.Controls.Add(this.rbtnHex);
            this.Controls.Add(this.ckTimestamp);
            this.Name = "DataReceive";
            this.Size = new System.Drawing.Size(523, 210);
            this.CMS_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.RadioButton rbtnHex;
        private System.Windows.Forms.RadioButton rbtnASCII;
        private System.Windows.Forms.ContextMenuStrip CMS_Main;
        private System.Windows.Forms.ToolStripMenuItem MS_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_ToInt;
        private System.Windows.Forms.ToolStripMenuItem MS_ToFloat;
        private System.Windows.Forms.ToolStripMenuItem MS_ToDouble;
        private System.Windows.Forms.CheckBox ckTimestamp;
        private System.Windows.Forms.Button button1;
    }
}
