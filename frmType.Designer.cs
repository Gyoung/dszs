namespace LeafSoft
{
    partial class frmType
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
            this.gvType = new System.Windows.Forms.DataGridView();
            this.devType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devUnit1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devUnit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devDrop = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.devMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRow = new System.Windows.Forms.ToolStripMenuItem();
            this.delRow = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRow = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvType)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvType
            // 
            this.gvType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.devType,
            this.devName,
            this.devUnit1,
            this.devUnit2,
            this.devDrop,
            this.devMin,
            this.devMax});
            this.gvType.Location = new System.Drawing.Point(12, 30);
            this.gvType.MultiSelect = false;
            this.gvType.Name = "gvType";
            this.gvType.RowTemplate.Height = 23;
            this.gvType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvType.Size = new System.Drawing.Size(745, 264);
            this.gvType.TabIndex = 0;
            // 
            // devType
            // 
            this.devType.HeaderText = "设备系列";
            this.devType.Name = "devType";
            // 
            // devName
            // 
            this.devName.HeaderText = "设备名称";
            this.devName.Name = "devName";
            // 
            // devUnit1
            // 
            this.devUnit1.HeaderText = "单位1";
            this.devUnit1.Name = "devUnit1";
            // 
            // devUnit2
            // 
            this.devUnit2.HeaderText = "单位2";
            this.devUnit2.Name = "devUnit2";
            // 
            // devDrop
            // 
            this.devDrop.HeaderText = "下拉选择";
            this.devDrop.Items.AddRange(new object[] {
            "A:0",
            "B:1",
            "C:10",
            "D:100"});
            this.devDrop.Name = "devDrop";
            // 
            // devMin
            // 
            this.devMin.HeaderText = "最小值";
            this.devMin.Name = "devMin";
            this.devMin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.devMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // devMax
            // 
            this.devMax.HeaderText = "最大值";
            this.devMax.Name = "devMax";
            this.devMax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.devMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRow,
            this.delRow,
            this.saveRow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRow
            // 
            this.addRow.Name = "addRow";
            this.addRow.Size = new System.Drawing.Size(44, 21);
            this.addRow.Text = "新增";
            this.addRow.Click += new System.EventHandler(this.addRow_Click);
            // 
            // delRow
            // 
            this.delRow.Name = "delRow";
            this.delRow.Size = new System.Drawing.Size(44, 21);
            this.delRow.Text = "删除";
            this.delRow.Click += new System.EventHandler(this.delRow_Click);
            // 
            // saveRow
            // 
            this.saveRow.Name = "saveRow";
            this.saveRow.Size = new System.Drawing.Size(44, 21);
            this.saveRow.Text = "保存";
            this.saveRow.Click += new System.EventHandler(this.saveRow_Click);
            // 
            // frmType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 306);
            this.Controls.Add(this.gvType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增设备类型";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmType_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gvType)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRow;
        private System.Windows.Forms.ToolStripMenuItem delRow;
        private System.Windows.Forms.ToolStripMenuItem saveRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn devType;
        private System.Windows.Forms.DataGridViewTextBoxColumn devName;
        private System.Windows.Forms.DataGridViewTextBoxColumn devUnit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn devUnit2;
        private System.Windows.Forms.DataGridViewComboBoxColumn devDrop;
        private System.Windows.Forms.DataGridViewTextBoxColumn devMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn devMax;
    }
}