using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LeafSoft.LeafControl;
using System.Net;
using System.Threading;
using LeafSoft.Model;
using LeafSoft.Units;
using LeafSoft.Lib;
using System.Diagnostics;
using System.IO;

namespace LeafSoft
{
    public partial class yyzq : Form
    {


        List<TypeData> typeList = new List<TypeData>();
        List<Device> deviceList = new List<Device>();

        public yyzq()
        {
            InitializeComponent();


            this.Text = Lib.AppInfor.AssemblyTitle + "[V" + Lib.AppInfor.AssemblyVersion + "][" + Lib.AppInfor.AssemblyCopyright + "]";

            Control[] controls = DataReceiver.Controls.Find("rbtnHex", false);
            if (controls.Length > 0)
            {
                (controls[0] as RadioButton).Checked = true;
            }

            Control[] controls1 = dataReceive1.Controls.Find("rbtnHex", false);
            if (controls1.Length > 0)
            {
                (controls1[0] as RadioButton).Checked = true;
            }
            loadDataType();
            deviceList = XmlUnits.getDeviceData();

        }

        private void loadDataType()
        {
            this.dataGridView2.Rows.Clear();
            typeList = XmlUnits.getTypeData();
            foreach (TypeData item in typeList)
            {
                int rowIndex = this.dataGridView2.Rows.Add();
                this.dataGridView2.Rows[rowIndex].Cells[0].Value = item.Name;
            }
        }
        private void CreateNewTest(object p, string title, Icon icon)
        {
            Form frm = new Form();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Icon = icon;
            frm.Controls.Add((Control)p);
            frm.Width = 800;
            frm.Height = 500;
            frm.ShowIcon = true;
            frm.Text = title;
            frm.Show();
        }





        //qq
        private void lklQQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string qq = "1950190891";
                System.Diagnostics.Process.Start("tencent://message/?uin=" + qq + "&Site=yyzq.net&Menu=yes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //邮箱
        private void lklEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:market@zonewu.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //个人网页
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("www.zonewu.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //关于
        private void MS_AboutMe_Click(object sender, EventArgs e)
        {
            new AboutMe().ShowDialog();
        }

        private void comPanel1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabPage tabPage = this.tabControl1.SelectedTab;
            //tabPage.Controls.Count;
            Control dataGrid = findDataReciver(tabPage);
            BindingList<Model.CMD> dataSource = null;
            Command command = null;
            if (dataGrid != null)
            {
                Object gridView = ((DataGridView)dataGrid).DataSource;
                dataSource = gridView as BindingList<Model.CMD>;
            }


            if (dataSource != null)
            {
                string fileName = XmlUnits.saveXml(dataSource, command, tabPage.Name);
                MessageBox.Show("保存成功");
            }
        }




        private Control findDataReciver(Control control)
        {
            if (control is DataGridView)
            {
                return control;
            }

            for (int i = 0; i < control.Controls.Count; i++)
            {
                Control cl = control.Controls[i];
                Control clt = findDataReciver(cl);
                if (clt != null)
                {
                    return clt;
                }
            }
            return null;

        }

        private void yyzq_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            TabPage tabPage = this.tabControl1.SelectedTab;
            //tabPage.Controls.Count;
            Control dataGrid = findDataReciver(tabPage);
            if (dataGrid != null)
            {
                DataGridView gv = (DataGridView)dataGrid;

                BindingList<CMD> list = XmlUnits.getXmlData(tabPage.Name);
                if (list.Count == 0)
                {
                    MessageBox.Show("无数据!");
                    return;
                }
                gv.DataSource = list;
                for (int i = 0; i < gv.Rows.Count; i++)
                {
                    gv.Rows[i].Cells[4].Value = "发送";
                }
            }
        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                bytesBox1.IsHex = EnumType.CMDType.Hex;
            }
            else
            {
                bytesBox1.IsHex = EnumType.CMDType.ASCII;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = bytesBox1.GetCMD().Bytes;
                DataReceiver.AddData(data, true);
                if (this.ckLine.Checked)
                {
                    byte[] bytes = { 0x0d, 0x0a };
                    int length = data.Length + bytes.Length;
                    byte[] bs = new byte[length];
                    for (int i = 0; i < data.Length; i++)
                    {
                        bs[i] = data[i];
                    }
                    bs[length - 2] = 0x0d;
                    bs[length - 1] = 0x0a;
                    if (udpClient.SendData(bs) == true)
                    {
                        MDataCounter.PlusSend(bs.Length);
                    }
                }
                else
                {
                    if (udpClient.SendData(data) == true)
                    {
                        MDataCounter.PlusSend(data.Length);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        List<ShowData> waterTemperature = new List<ShowData>();

        private void Configer_DataReceived(object sender, byte[] data)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.AppendFormat("{0:x2}" + " ", data[i]);
            }
            string receiveData = sb.ToString();
            if (receiveData != null)
            {
                string[] datas = receiveData.Split(' ');
                if (datas.Length > 8)
                {
                    ShowData showData = new ShowData();
                    showData.CreateTime = DateTime.Now.ToString();
                    showData.ZoneId = Convert.ToInt32(datas[1], 16).ToString(); //区域ID
                    showData.DeviceId = Convert.ToInt32(datas[2], 16).ToString(); //设备ID
                    showData.Type = Convert.ToInt32(datas[5], 16).ToString(); //设备类型

                    TypeData typeData = GetType(showData.Type);

                    double val1 = (double)Convert.ToInt32(datas[6] + datas[7], 16);
                    int n1 = 0;
                    if (typeData.DropType != "" && typeData.DropType.Split(':').Length > 1)
                    {
                        n1 = int.Parse(typeData.DropType.Split(':')[1]);
                    }
                    if (n1 > 0)
                    {
                        showData.Value1 = ((double)(val1 / n1)).ToString();//值1
                    }
                    else
                    {
                        showData.Value1 = Convert.ToInt32(datas[6] + datas[7], 16).ToString();
                    }
                    if (datas.Length > 10)
                    {
                        showData.Signal = Convert.ToInt32(datas[8], 16).ToString(); // 信号值
                        showData.Noise = Convert.ToInt32(datas[9], 16).ToString(); //信噪比
                    }

                    if (datas.Length > 12)
                    {
                        int n2 = 0;
                        if (typeData.DropType2 != "" && typeData.DropType2.Split(':').Length > 1)
                        {
                            n2 = int.Parse(typeData.DropType2.Split(':')[1]);
                        }
                        double val2 = (double)Convert.ToInt32(datas[8] + datas[9], 16);
                        if (n2 > 0)
                        {
                            showData.Value2 = ((double)(val2 / n2)).ToString(); //值1
                        }
                        else
                        {
                            showData.Value2 = Convert.ToInt32(datas[8] + datas[9], 16).ToString();
                        }
                        showData.Signal = Convert.ToInt32(datas[10], 16).ToString();
                        showData.Noise = Convert.ToInt32(datas[11], 16).ToString();

                    }
                    waterTemperature.Add(showData);
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        //gridview数据大于10000条，则自动保存，再清空gridview数据
                        if (this.dataGridView1.RowCount > 10000)
                        {
                            exportData("数据展示", this.dataGridView1, "采集器结果", true);
                            this.dataGridView1.Rows.Clear();
                            dataReceive1.CleanText();
                        }
                        devType.Enabled = false;
                        //this.dataGridView1.DataSource = waterTemperature;
                        //this.tmpHigh.ReadOnly = true;
                        //this.tmpLow.ReadOnly = true;
                        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();

                        int index = this.dataGridView1.Rows.Add();
                        this.dataGridView1.Rows[index].Cells["gvTime"].Value = showData.CreateTime;
                        this.dataGridView1.Rows[index].Cells["gvZone"].Value = showData.ZoneId;
                        this.dataGridView1.Rows[index].Cells["gvDevid"].Value = showData.DeviceId;
                        this.dataGridView1.Rows[index].Cells["gvType"].Value = typeData.Name;
                        this.dataGridView1.Rows[index].Cells["gvAddress"].Value = GetDevice(showData.DeviceId);
                        this.dataGridView1.Rows[index].Cells["gvSignal"].Value = showData.Signal;
                        this.dataGridView1.Rows[index].Cells["gvNoise"].Value = showData.Noise;

                        string text = "",text2="";
                        if (!string.IsNullOrEmpty(showData.Value1))
                        {
                            text += showData.Value1 + typeData.Value1 + " ";
                        }
                        if (!string.IsNullOrEmpty(showData.Value2))
                        {
                            text2 += showData.Value2 + typeData.Value2;
                        }

                        this.dataGridView1.Rows[index].Cells["gvValue1"].Value = text;
                        this.dataGridView1.Rows[index].Cells["gvValue2"].Value = text2;

                        this.dataGridView1.Rows[index].HeaderCell.Value = (index + 1).ToString();
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[index].Index;
                        if (!string.IsNullOrEmpty(typeData.MinValue) && !string.IsNullOrEmpty(typeData.MaxValue))
                        {
                            //double minValue = double.Parse(typeData.MinValue);
                            //double maxValue = double.Parse(typeData.MaxValue);
                            //double value = double.Parse(showData.Value1);
                            //if (value >= minValue && value <= maxValue)
                            //{
                            //    showData.Status = "正常";
                            //    cellStyle.ForeColor = Color.Green;
                            //}

                            //else
                            //{
                            //    showData.Status = "异常";
                            //    cellStyle.ForeColor = Color.Red;
                            //}
                            if (datas[4].Equals("1F",StringComparison.CurrentCultureIgnoreCase))
                            {
                                showData.Status = "正常";
                                cellStyle.ForeColor = Color.Green;
                            }
                            else if (datas[4].Equals("EE", StringComparison.CurrentCultureIgnoreCase))
                            {
                                showData.Status = "掉电";
                                cellStyle.ForeColor = Color.Red;
                            }
                        }
                        this.dataGridView1.Rows[index].Cells["gvStatus"].Value = showData.Status;
                        this.dataGridView1.Rows[index].Cells["gvStatus"].Style = cellStyle;
                    }));

                }
            }

            dataReceive1.AddData(data, false);

            dataCounter1.PlusReceive(data.Length);
        }


        /// <summary>
        /// 获取设备类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private TypeData GetType(string type)
        {
            foreach (TypeData item in typeList)
            {
                if (item.Type == type)
                    return item;
            }
            return new TypeData();
        }

        /// <summary>
        /// 获取设备地址
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private string GetDevice(string id)
        {
            foreach (Device item in deviceList)
            {
                if (item.Id == id)
                    return item.Address;
            }
            return "";
        }


        class ShowData
        {
            public string CreateTime { get; set; }

            public string ZoneId { get; set; }
            public string DeviceId { get; set; }

            public string Type { get; set; }

            public string Value1 { get; set; }

            public string Value2 { get; set; }

            public string Status { get; set; }

            public string Signal { get; set; }

            public string Noise { get; set; }
        }

        private void devType_Click(object sender, EventArgs e)
        {
            frmType frm = new frmType();
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                loadDataType();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            devType.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportData("数据展示", this.dataGridView1, "采集器结果", false);
        }
        private void exportData(string fileName, DataGridView dv, string title, bool isAuto)
        {
            string file = ExportExcel.ExportExcelData(fileName, dv, title);
            if (!isAuto)
            {
                if (file.Length > 0)
                {
                    MessageBox.Show("导出成功，路径：" + file);
                }
                else
                {
                    MessageBox.Show("导出失败，路径：" + file);
                }
            }
            else
            {
                if (file.Length > 0)
                {
                    lblFile.Text = file;
                }
                else
                {
                    lblFile.Text = "自动保存失败，时间" + DateTime.Now;
                }
            }

        }

        private void MS_AboutMe_Click_1(object sender, EventArgs e)
        {
            new AboutMe().ShowDialog();
        }

        private void lblFile_DoubleClick(object sender, EventArgs e)
        {
            if (lblFile.Text.Length > 0 && File.Exists(lblFile.Text))
            {
                Process m_Process = new Process();
                m_Process.StartInfo.FileName = lblFile.Text;
                m_Process.Start();
            }
        }

    }
}
