using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LeafSoft
{
    public partial class frmFast : Form
    {
        public frmFast()
        {
            InitializeComponent();

            //this.comboBox12.SelectedValue = "";
            this.cbSpeed.SelectedItem = "3";//速度
            this.comboBox1.SelectedItem = "2";//设备类型
            this.comboBox2.SelectedItem = "115200";//波特率
            this.comboBox3.SelectedItem = "None";//检验位
            this.comboBox11.SelectedItem = "";//数据位
            this.comboBox4.SelectedItem = "1";//停止位
            this.comboBox5.SelectedItem = "0";//休眠模式
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateNumber(txtNetNumber);
                ValidateNumber(txtLocalId);
                ValidateNumber(txtTCId);
                ValidateNumber(txtZJId);
                ValidateNumber(txtPl,1);
                List<string> commands = GetCommand();
                foreach (string cmd in commands)
                {
                    bool result= SendData(cmd);
                    if (!result)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool SendData(string cmd)
        {
           
            if (cbLine.Checked)
            {
                cmd= cmd + "\r\n"; //增加换行
            }
            byte[] data = new ASCIIEncoding().GetBytes(cmd);
            DataReceiver.AddData(data, true);
            bool result= Configer.SendData(data);
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
            return result;
        }


        private List<string> GetCommand()
        {
            List<string> commands = new List<string>();
           // commands.Add("+ATM");
            Control.ControlCollection controls = groupBox3.Controls;
            foreach (Control item in controls)
            {
                if (item is TextBox)
                {
                    TextBox textbox = item as TextBox;
                    if (textbox.Text.Length > 0 && textbox.Tag!=null)
                    {
                        commands.Add(textbox.Tag + textbox.Text);
                    }
                }
                else if (item is ComboBox)
                {
                    ComboBox combobox = item as ComboBox;
                    if (combobox.SelectedItem != null && combobox.Tag != null)
                    {
                        commands.Add(combobox.Tag + combobox.SelectedItem.ToString());
                    }
                }

            }
            return commands;

        }


        private void ValidateNumber(TextBox textbox,int type=0)
        {
            int number=0;
            if (textbox.Text.Length == 0)
                return;
            try
            {
                number = int.Parse(textbox.Text);
                if (type == 0) //0-255
                {
                    if (number < 0 || number > 255)
                    {
                        textbox.Focus();
                        throw new Exception("范围需要在0-255之间");
                    }
                }
                else if (type == 1) //410~441、470~510、850~950
                {
                    if (number < 410 || (number > 441&&number<470)||(number>510&&number<850)||number>950)
                    {
                        textbox.Focus();
                        throw new Exception("范围需要在410~441、470~510、850~950之间");
                    }
                }else if(type==2) //5-20
                { 
                     if (number < 5 || number > 20)
                    {
                        textbox.Focus();
                        throw new Exception("范围需要在5-20之间");
                    }
                }
                
               
            }
            catch (Exception ex)
            {
                textbox.Focus();
                throw new Exception(ex.Message);
            }
              
        }

        private void Configer_DataReceived(object sender, byte[] data)
        {

            string receiveData = new ASCIIEncoding().GetString(data);
            if (receiveData != null && receiveData.StartsWith("Device"))
            {
                setValue(receiveData);
            }
            DataReceiver.AddData(data, false);
        }


        private void setValue(string input)
        {
            string[] list = input.Split(new char[] { '\r', '\n' });
            if (list != null && list.Length > 0)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    string ls = list[i];
                    if (ls.StartsWith("COM1 Baud"))
                    {
                        this.comboBox2.SelectedItem = ls.Split(':')[1];
                    }
                    else if (ls.StartsWith("COM1 Params"))
                    {
                        string values = ls.Split(':')[1].Trim();
                        if (values.Length == 3)
                        {
                            //数据位
                            comboBox11.SelectedItem = values[0].ToString();
                            //检验位
                            comboBox3.SelectedItem = GetFullValue(values[1].ToString());
                            //停止位
                            comboBox4.SelectedItem = values[2].ToString();
                        }
                    }
                    else if (ls.StartsWith("Radio Speed"))
                    {
                        this.cbSpeed.SelectedItem = ls.Split(':')[1];
                    }
                    else if (ls.StartsWith("Sleep mode"))
                    {
                        this.comboBox5.SelectedItem = ls.Split(':')[1];
                    }
                    else if (ls.StartsWith("NSID"))
                    {
                        txtNetNumber.Text = ls.Split(':')[1];
                    }
                    else if (ls.StartsWith("Device ID"))
                    {
                        txtLocalId.Text = ls.Split(':')[1];
                    }
                    else if (ls.StartsWith("RF transmit Power"))
                    {
                        txtFsgl.Text = ls.Split(':')[1];
                    }
                    else if (ls.StartsWith("Trans Addr"))
                    {
                        txtTCId.Text = ls.Split(':')[1];
                    }
                    else if (ls.StartsWith("Relay Addr"))
                    {
                        txtZJId.Text = ls.Split(':')[1];
                    }
                }
            }
        }

        private string GetFullValue(string s)
        {
            string value = "";
            switch (s)
            {
                case "N": value = "None"; break;
                case "O": value = "Odd"; break;
                case "E": value = "Even"; break;
                case "M": value = "Mark"; break;
                case "S": value = "Space"; break;
                default: value = "None"; break;

            }
            return value;
        }

        //保存配置
        private void button3_Click(object sender, EventArgs e)
        {
            SendData("AT+SAVE");
        }

        //重启
        private void button4_Click(object sender, EventArgs e)
        {
            SendData("AT+RSET");
            

        }

        //恢复出厂设置
        private void button5_Click(object sender, EventArgs e)
        {
            SendData("AT+FACT");
        }

        private void frmFast_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configer.ClearSelf();
        }

        //进入 AT命令
        private void button2_Click(object sender, EventArgs e)
        {
            SendData("+ATM");
            this.cbLine.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SendData("AT+SHOW");
        }
    }
}
