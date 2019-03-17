using LeafSoft.Model;
using LeafSoft.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft
{
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            List<TypeData> data = XmlUnits.getTypeData();
            foreach (TypeData item in data)
            {
               int rowIndex= this.gvType.Rows.Add();
               this.gvType.Rows[rowIndex].Cells["devType"].Value = item.Type;
               this.gvType.Rows[rowIndex].Cells["devName"].Value = item.Name;
               this.gvType.Rows[rowIndex].Cells["devAddress"].Value = item.Address;
               this.gvType.Rows[rowIndex].Cells["devUnit1"].Value = item.Value1;
               this.gvType.Rows[rowIndex].Cells["devUnit2"].Value = item.Value2;
               this.gvType.Rows[rowIndex].Cells["devDrop"].Value = item.DropType;
               this.gvType.Rows[rowIndex].Cells["devMin"].Value = item.MinValue;
               this.gvType.Rows[rowIndex].Cells["devMax"].Value = item.MaxValue;
            }
            //this.gvType.DataSource = data;
           
        }

        private void addRow_Click(object sender, EventArgs e)
        {
            this.gvType.Rows.Add();
        }

        private void delRow_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection rows = this.gvType.SelectedRows;
                if (rows.Count == 0)
                {
                    MessageBox.Show("请选择行！");
                    return;
                }
                else
                {
                    this.gvType.Rows.Remove(rows[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void saveRow_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection rows=this.gvType.Rows;
            List<TypeData> list = new List<TypeData>();
            foreach (DataGridViewRow row in rows)
            {
                TypeData type = new TypeData();
                type.Type = row.Cells["devType"].Value == null ? "" : row.Cells["devType"].Value.ToString();
                type.Name = row.Cells["devName"].Value == null ? "" : row.Cells["devName"].Value.ToString();
                type.Address = row.Cells["devAddress"].Value == null ? "" : row.Cells["devAddress"].Value.ToString();
                type.Value1 = row.Cells["devUnit1"].Value == null ? "" : row.Cells["devUnit1"].Value.ToString();
                type.Value2 = row.Cells["devUnit2"].Value == null ? "" : row.Cells["devUnit2"].Value.ToString();
                type.DropType = row.Cells["devDrop"].Value == null ? "" : row.Cells["devDrop"].Value.ToString();
                type.MinValue = row.Cells["devMin"].Value == null ? "" : row.Cells["devMin"].Value.ToString();
                type.MaxValue = row.Cells["devMax"].Value == null ? "" : row.Cells["devMax"].Value.ToString();
                if (type.Name == "" && type.DropType == "")
                {
                    continue;
                }
                list.Add(type);
            }
            string fileName=XmlUnits.saveType(list);
            if (fileName.Length > 0)
            {
                MessageBox.Show("保存成功!");
                //this.DialogResult = DialogResult.Yes;
            }
        }

        private void frmType_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;

        }
    }
}
