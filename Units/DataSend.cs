using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Lib;
using System.Threading;
/*---------------作者：叶知秋----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.Units
{
    public partial class DataSend : UserControl
    {
        BindingList<Model.CMD> lstCMD = new BindingList<Model.CMD>();

        public event LeafEvent.DataSendHandler EventDataSend;

        /// <summary>
        /// 是否在自动循环发送状态
        /// </summary>
        bool AutoSend = false;

        public DataSend()
        {
            InitializeComponent();
            dgCMD.AutoGenerateColumns = false;
            //lstCMD.Add(new Model.CMD(EnumType.CMDType.ASCII, new ASCIIEncoding().GetBytes("www.zonewu.com"),"备注"));
            //dgCMD.DataSource = lstCMD;

            dgCMD.DataSource = lstCMD;
        }

        private BindingList<Model.CMD> getListCmd()
        {
            if (dgCMD.DataSource != null)
            {
                lstCMD = dgCMD.DataSource as BindingList<Model.CMD>;
            }
            return lstCMD;
        }


        private BindingList<Model.CMD> getCheckedCmd()
        {
            BindingList<Model.CMD> lstCmd = getListCmd();
            BindingList<Model.CMD> cmds = new BindingList<Model.CMD>();
            for (int i = 0; i < lstCmd.Count; i++)
            {
                object cbxValue = dgCMD.Rows[i].Cells[0].Value;
                if (cbxValue is bool && cbxValue.Equals(true))
                {
                    cmds.Add(lstCmd[i]);
                } 
            }
            return cmds;
        }

        private void dgCMD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {//点击了发送按钮 
                if (EventDataSend != null)
                {
                    lstCMD = dgCMD.DataSource as BindingList<Model.CMD>;
                    EventDataSend(lstCMD[e.RowIndex].Bytes);
                }
            }
        }

        private void dgCMD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgCMD.Rows[e.RowIndex].Cells[4].Value = "发送";
        }

        /// <summary>
        /// 添加调试命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Add_Click(object sender, EventArgs e)
        {
            frmCMD fCmd = new frmCMD();
            if (fCmd.ShowDialog() == DialogResult.OK)
            {
                getListCmd().Add(fCmd.NewCMD);
            }
        }

        /// <summary>
        /// 编辑调试命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Edit_Click(object sender, EventArgs e)
        {
            if (dgCMD.SelectedRows.Count > 0)
            {
                LeafSoft.Model.CMD cmd = getListCmd()[dgCMD.SelectedRows[0].Index];
                frmCMD fCmd = new frmCMD(cmd);
                if (fCmd.ShowDialog() == DialogResult.OK)
                {
                    fCmd.NewCMD.Remark = cmd.Remark;
                    getListCmd()[dgCMD.SelectedRows[0].Index] = fCmd.NewCMD;
                }
            }
        }

        /// <summary>
        /// 删除调试命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MS_Delete_Click(object sender, EventArgs e)
        {
            if (dgCMD.SelectedRows.Count > 0)
            {
                getListCmd().RemoveAt(dgCMD.SelectedRows[0].Index);
            }
        }

        private void btnAutoSend_Click(object sender, EventArgs e)
        {
            if (AutoSend == false)
            {
                btnAutoSend.Text = "停止循环";
                dgCMD.Enabled = false;
                nmDelay.Enabled = false;
                AutoSend = true;
                Thread ThTestL = new Thread(new ParameterizedThreadStart(TAutoSend));
                ThTestL.IsBackground = true;
                ThTestL.Start(nmDelay.Value);
            }
            else
            {
                StopAutoSend();
            }
        }

        /// <summary>
        /// 自动发送命令线程
        /// </summary>
        private void TAutoSend(object Interval)
        {
            try
            {
                object sendlock = new object();
                int SendInterval = Convert.ToInt32(Interval);
                while (AutoSend)
                {
                    BindingList<Model.CMD> checkedCmds = getCheckedCmd();
                    for (int i = 0; i < checkedCmds.Count; i++)
                    {
                        if (AutoSend)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                if (EventDataSend != null)
                                    {
                                        if (EventDataSend(checkedCmds[i].Bytes) == false)
                                        {
                                            StopAutoSend();
                                        }
                                    }
                            }));
                            Thread.Sleep(SendInterval);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch { };
        }

        /// <summary>
        /// 停止循环发送
        /// </summary>
        private void StopAutoSend()
        {
            AutoSend = false;
            btnAutoSend.Text = "循环发送";
            dgCMD.Enabled = true;
            nmDelay.Enabled = true;
        }

        private void dgCMD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgCMD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && e.ColumnIndex==3)
            {
                (this.dgCMD.DataSource as BindingList<Model.CMD>)[e.RowIndex].Remark = this.dgCMD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void dgCMD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 3)
            {
                this.dgCMD.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;//将当前单元格设为可读

                this.dgCMD.CurrentCell = this.dgCMD.Rows[e.RowIndex].Cells[e.ColumnIndex];//获取当前单元格
                this.dgCMD.BeginEdit(true);//将单元格设为编辑状态
            }
        }
    }
}
