﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LeafSoft.Lib;
/*---------------作者：叶知秋----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace LeafSoft.PartPanel
{
    public partial class TCPClientPanel : BasePanel
    {
        public TCPClientPanel()
        {
            InitializeComponent();
        }

        private bool DataSender_EventDataSend(byte[] data)
        {
            if (Configer.SendData(data) == true)
            {
                MDataCounter.PlusSend(data.Length);
                if (this.ckLine.Checked)
                {
                    Byte[] bytes = { 0x0d, 0x0a };
                    if (Configer.SendData(bytes) == true)
                    {
                        MDataCounter.PlusSend(bytes.Length);
                    }
                }
                return true;
            }
            return false;
        }

        private void Configer_DataReceived(object sender, byte[] data)
        {
            DataReceiver.AddData(data);
            MDataCounter.PlusReceive(data.Length);
        }

        public override void ClearSelf()
        {
            Configer.ClearSelf();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = bytesBox1.GetCMD().Bytes;
                DataSender_EventDataSend(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
