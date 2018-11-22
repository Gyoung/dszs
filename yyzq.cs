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
using LeafSoft.PartPanel;
using LeafSoft.Units;
using LeafSoft.Lib;
/*---------------作者：叶知秋----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/

namespace LeafSoft
{
    public partial class yyzq : Form
    {
        frmCheck fc = new frmCheck();
        frmBytes fb = new frmBytes();

        public yyzq()
        {
            InitializeComponent();
            fc.TopMost = true;
            fb.TopMost = true;
            //            this.Text = Lib.AppInfor.AssemblyTitle + "[v" + Lib.AppInfor.AssemblyVersion +"]["+ Lib.AppInfor.AssemblyCopyright + "][常州-Maximus]";
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
            frm.FormClosing += new FormClosingEventHandler(frm_FormClosing);
            frm.Show();
        }

        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = (Form)sender;
            PartPanel.BasePanel bp = (PartPanel.BasePanel)frm.Controls[0];
            bp.ClearSelf();
        }
        private void MS_NewTCPServer_Click(object sender, EventArgs e)
        {
            TCPServerPanel tp = new TCPServerPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "TCP Server[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.tcp);
        }

        private void MS_NewTCPClient_Click(object sender, EventArgs e)
        {
            TCPClientPanel tp = new TCPClientPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "TCP Client[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.tcp);
        }
          
        private void MS_NewUDPServer_Click(object sender, EventArgs e)
        {
            UDPServerPanel tp = new UDPServerPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "UDP Server[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.udp);
        }

        private void MS_NewUDPClient_Click(object sender, EventArgs e)
        {
            UDPClientPanel tp = new UDPClientPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "UDP Client[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.udp);
        }

        private void MS_NewRs232_Click(object sender, EventArgs e)
        {
            ComPanel tp = new ComPanel();
            tp.Dock = DockStyle.Fill;
            CreateNewTest(tp, "COM[" + DateTime.Now.ToString("HHmmss") + "]", Properties.Resources.com);
        }

        private void MS_Check_Click(object sender, EventArgs e)
        {
            if (fc.IsDisposed == true)
            {
                fc = new frmCheck();
                fc.TopMost = true;
            }
            fc.Show();
        }

        private void MS_Bytes_Click(object sender, EventArgs e)
        {
            if (fb.IsDisposed == true)
            {
                fb = new frmBytes();
                fb.TopMost = true;
            }
            fb.Show();
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
                System.Diagnostics.Process.Start("www.zonewu.com");//Start("www.yyzq.net/Index");
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
            Control netRs = findNetRs(tabPage);
            if (netRs != null)
            {
                NetRs232 netRs32 = (NetRs232)netRs;
                command = new Command();
                for (int i = 0; i < netRs32.Controls.Count; i++)
                {
                    Control cl = netRs32.Controls[i];
                    if (cl is ComboBox)
                    {
                        ComboBox cb = (ComboBox)cl;
                        if (cb.Name == "drpComList")
                        {
                            command.Com = cb.Text;
                        }
                        else if (cb.Name == "drpBaudRate")
                        {
                            command.Ptl = cb.Text;
                        }
                        else if (cb.Name == "drpParity")
                        {
                            command.Xjw = cb.Text;
                        }
                        else if (cb.Name == "drpDataBits")
                        {
                            command.Sjw = cb.Text;
                        }
                        else if (cb.Name == "drpStopBits")
                        {
                            command.Tzw = cb.Text;
                        }
                    }
                }
            }
            if (dataSource != null)
            {
                string fileName = XmlUnits.saveXml(dataSource, command, tabPage.Name);
                MessageBox.Show("保存成功");
            }
        }


        private Control findNetRs(Control control)
        {
            if (control is NetRs232)
            {
                return control;
            }

            for (int i = 0; i < control.Controls.Count; i++)
            {
                Control cl = control.Controls[i];
                Control clt = findNetRs(cl);
                if (clt != null)
                {
                    return clt;
                }
            }
            return null;

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
            TabPage tabPage = this.tabControl1.SelectedTab;
            //tabPage.Controls.Count;
            Control dataGrid = findDataReciver(tabPage);
            if (dataGrid != null)
            {
                DataGridView gv = (DataGridView)dataGrid;
                gv.DataSource = XmlUnits.getXmlData(tabPage.Name);
                for (int i = 0; i < gv.Rows.Count; i++)
                {
                    gv.Rows[i].Cells[4].Value = "发送";
                }
            }
            Control netRs = findNetRs(tabPage);
            if (netRs != null)
            {
                NetRs232 netRs32 = (NetRs232)netRs;
                Command command = XmlUnits.getCommandData(tabPage.Name);
                for (int i = 0; i < netRs32.Controls.Count; i++)
                {
                    Control cl = netRs32.Controls[i];
                    if (cl is ComboBox)
                    {
                        ComboBox cb = (ComboBox)cl;
                        if (cb.Name == "drpComList")
                        {
                            cb.Text = command.Com;
                        }
                        else if (cb.Name == "drpBaudRate")
                        {
                            cb.Text = command.Ptl;
                        }
                        else if (cb.Name == "drpParity")
                        {
                            cb.Text = command.Xjw;
                        }
                        else if (cb.Name == "drpDataBits")
                        {
                            cb.Text = command.Sjw;
                        }
                        else if (cb.Name == "drpStopBits")
                        {
                            cb.Text = command.Tzw;
                        }
                    }
                }
            }
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

        private void FaxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFast tp = new frmFast();
            tp.Show();
        }

        private void 数据展示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShow Fs = new FrmShow();
            Fs.Show();
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
                    showData.ZoneId = Convert.ToInt32(datas[1], 16).ToString();
                    showData.DeviceId = Convert.ToInt32(datas[2], 16).ToString();
                    showData.Type = Convert.ToInt32(datas[5], 16).ToString();
                    showData.Value1 = Convert.ToInt32(datas[6] + datas[7], 16).ToString();
                    if (showData.Value1 != null && showData.Value1.Length > 2)
                    {
                        showData.Value1 = showData.Value1.Insert(2, "."); //增加小数点
                    }
                    if (datas.Length > 10)
                    {
                        showData.Value2 = Convert.ToInt32(datas[8] + datas[9], 16).ToString();
                        if (showData.Value2 != null && showData.Value2.Length > 2)
                        {
                            showData.Value2 = showData.Value2.Insert(2, "."); //增加小数点
                        }
                    }
                    waterTemperature.Add(showData);
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        //this.dataGridView1.DataSource = waterTemperature;
                        //this.tmpHigh.ReadOnly = true;
                        //this.tmpLow.ReadOnly = true;
                        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                        if (showData.Type == "17")
                        {
                            int index = this.dataGridView1.Rows.Add();
                            this.dataGridView1.Rows[index].Cells[0].Value = showData.CreateTime;
                            this.dataGridView1.Rows[index].Cells[1].Value = showData.ZoneId;
                            this.dataGridView1.Rows[index].Cells[2].Value = showData.DeviceId;
                            this.dataGridView1.Rows[index].Cells[3].Value = GetTypeName(showData.Type);
                            this.dataGridView1.Rows[index].Cells[4].Value = "温度：" + showData.Value2 + "℃" + " " + "湿度:" + showData.Value1 + "%";
                            //if (double.Parse(showData.Value2) < double.Parse(tmpLow.Text) || double.Parse(showData.Value2) > double.Parse(tmpHigh.Text))
                            //{
                            //    showData.Status = "异常";
                            //    cellStyle.ForeColor = Color.Red;
                            //}

                            //else
                            //{
                            //    showData.Status = "正常";
                            //    cellStyle.ForeColor = Color.Green;
                            //}
                            this.dataGridView1.Rows[index].Cells[5].Value = showData.Status;
                            this.dataGridView1.Rows[index].Cells[5].Style = cellStyle;
                            this.dataGridView1.Rows[index].HeaderCell.Value = (index + 1).ToString();
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[index].Index;
                        }
                        if (showData.Type == "32")
                        {
                            int index = this.dataGridView1.Rows.Add();
                            this.dataGridView1.Rows[index].Cells[0].Value = showData.CreateTime;
                            this.dataGridView1.Rows[index].Cells[1].Value = showData.ZoneId;
                            this.dataGridView1.Rows[index].Cells[2].Value = showData.DeviceId;
                            this.dataGridView1.Rows[index].Cells[3].Value = GetTypeName(showData.Type);
                            this.dataGridView1.Rows[index].Cells[4].Value = "IO：" + showData.Value1;
                            if (double.Parse(showData.Value1) == 0)
                            {
                                showData.Status = "正常";
                                cellStyle.ForeColor = Color.Green;
                            }

                            else
                            {
                                showData.Status = "异常";
                                cellStyle.ForeColor = Color.Red;
                            }
                            this.dataGridView1.Rows[index].Cells[5].Value = showData.Status;
                            this.dataGridView1.Rows[index].Cells[5].Style = cellStyle;
                            this.dataGridView1.Rows[index].HeaderCell.Value = (index + 1).ToString();
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[index].Index;
                        }


                        else if (showData.Type == "33")
                        {
                            int index = this.dataGridView1.Rows.Add();
                            this.dataGridView1.Rows[index].Cells[0].Value = showData.CreateTime;
                            this.dataGridView1.Rows[index].Cells[1].Value = showData.ZoneId;
                            this.dataGridView1.Rows[index].Cells[2].Value = showData.DeviceId;
                            this.dataGridView1.Rows[index].Cells[3].Value = GetTypeName(showData.Type);
                            this.dataGridView1.Rows[index].Cells[4].Value = showData.Value1;
                            if (double.Parse(showData.Value1) == 0)
                            {
                                showData.Status = "正常";
                                cellStyle.ForeColor = Color.Green;
                            }

                            else
                            {
                                showData.Status = "异常";
                                cellStyle.ForeColor = Color.Red;
                            }
                            this.dataGridView1.Rows[index].Cells[5].Value = showData.Status;
                            this.dataGridView1.Rows[index].Cells[5].Style = cellStyle;
                            this.dataGridView1.Rows[index].HeaderCell.Value = (index + 1).ToString();
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[index].Index;
                        }
                        if (showData.Type == "34")
                        {
                            int index = this.dataGridView1.Rows.Add();
                            this.dataGridView1.Rows[index].Cells[0].Value = showData.CreateTime;
                            this.dataGridView1.Rows[index].Cells[1].Value = showData.ZoneId;
                            this.dataGridView1.Rows[index].Cells[2].Value = showData.DeviceId;
                            this.dataGridView1.Rows[index].Cells[3].Value = GetTypeName(showData.Type);
                            this.dataGridView1.Rows[index].Cells[4].Value = "水位：" + showData.Value1 + "CM";


                            this.dataGridView1.Rows[index].Cells[5].Value = showData.Status;
                            this.dataGridView1.Rows[index].Cells[5].Style = cellStyle;
                            this.dataGridView1.Rows[index].HeaderCell.Value = (index + 1).ToString();
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[index].Index;
                        }
                        if (showData.Type == "35")
                        {
                            int index = this.dataGridView1.Rows.Add();
                            this.dataGridView1.Rows[index].Cells[0].Value = showData.CreateTime;
                            this.dataGridView1.Rows[index].Cells[1].Value = showData.ZoneId;
                            this.dataGridView1.Rows[index].Cells[2].Value = showData.DeviceId;
                            this.dataGridView1.Rows[index].Cells[3].Value = GetTypeName(showData.Type);
                            this.dataGridView1.Rows[index].Cells[4].Value = "压力：" + showData.Value1 + "MPa";

                            this.dataGridView1.Rows[index].Cells[5].Value = showData.Status;
                            this.dataGridView1.Rows[index].Cells[5].Style = cellStyle;
                            this.dataGridView1.Rows[index].HeaderCell.Value = (index + 1).ToString();
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[index].Index;
                        }


                    }));

                }
            }

            dataReceive1.AddData(data, false);
            MDataCounter.PlusReceive(data.Length);
        }


        /// <summary>
        /// 获取设备中文名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private string GetTypeName(string type)
        {
            if (type == "16")
                return "温度采集器";
            if (type == "17")
                return "温湿度采集器";
            if (type == "32")
                return "高压监控";
            if (type == "33")
                return "水浸采集器";
            if (type == "34")
                return "液位采集器";
            if (type == "35")
                return "压力采集器";
            return type;
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
        }

        //博客
        /*        private void lklBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                    try
                    {
                        System.Diagnostics.Process.Start("http://blog.csdn.net/sqqyq");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }*/
    }
}
