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
                for(int i = 0; i < gv.Rows.Count; i++)
                {
                    gv.Rows[i].Cells[4].Value= "发送";
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
