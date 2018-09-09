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
            //this.cbSpeed.SelectedItem = "3";//速度
            //this.comboBox1.SelectedItem = "2";//设备类型
            //this.comboBox2.SelectedItem = "115200";//波特率
            //this.comboBox3.SelectedItem = "None";//检验位
            //this.comboBox11.SelectedItem = "";//数据位
            //this.comboBox4.SelectedItem = "1";//停止位
            //this.comboBox5.SelectedItem = "0";//休眠模式
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendData("AT+SHOW");
          
        }


        private bool SendData(string cmd)
        {
            if (cbLine.Checked)
            {
                cmd = cmd + "\r\n"; //增加换行
            }
            byte[] data = new ASCIIEncoding().GetBytes(cmd.ToString());
            DataReceiver.AddData(data, true);
            bool result = Configer.SendData(data);
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
            return result;
            //Thread thread = new Thread(new ParameterizedThreadStart(SendData2));
            //thread.Start(cmd);
            //return true;
        }


        private void SendData2(object cmd)
        {
            if (cbLine.Checked)
            {
                cmd = cmd + "\r\n"; //增加换行
            }
            byte[] data = new ASCIIEncoding().GetBytes(cmd.ToString());
            DataReceiver.AddData(data, true);
            bool result = Configer.SendData(data);
            Thread.Sleep(TimeSpan.FromMilliseconds(500));
           
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
                        if (combobox.Tag.ToString().StartsWith("AT+BAUD"))
                        {
                            commands.Add(combobox.Tag + ChangeBotli(combobox.SelectedItem.ToString()));
                        }
                        else if (combobox.Tag.ToString().StartsWith("AT+PARY"))
                        {
                            commands.Add(combobox.Tag + GetJyValue(combobox.SelectedItem.ToString()));
                        }
                        else if (combobox.Tag.ToString().StartsWith("AT+TYPE"))
                        {
                            commands.Add(combobox.Tag + GetDeviceValue(combobox.SelectedItem.ToString()));
                        }
                        else if (combobox.Tag.ToString().StartsWith("AT+STOP"))
                        {
                            commands.Add(combobox.Tag + changestop(combobox.SelectedItem.ToString()));
                        }
                        else
                        {
                            commands.Add(combobox.Tag + combobox.SelectedItem.ToString());
                        }
                    }
                }

            }
            return commands;

        }

        private string ChangeBotli(string input)
        {
            string returnValue = "";
            switch (input)
            {
                case "600": returnValue = "1"; break;
                case "1200": returnValue = "2"; break;
                case "2400": returnValue = "3"; break;
                case "4800": returnValue = "4"; break;
                case "9600": returnValue = "5"; break;
                case "19200": returnValue = "6"; break;
                case "38400": returnValue = "7"; break;
                case "57600": returnValue = "8"; break;
                case "115200": returnValue = "9"; break;
                default: returnValue = "9"; break;
            }
            return returnValue;
        }

        private string RevertBotli(string input)
        {
            string returnValue = "";
            switch (input)
            {
                case "1": returnValue = "600"; break;
                case "2": returnValue ="1200"; break;
                case "3": returnValue ="2400"; break;
                case "4": returnValue ="4800"; break;
                case "5": returnValue ="9600"; break;
                case "6": returnValue ="19200"; break;
                case "7": returnValue= "38400"; break;
                case "8": returnValue ="57600"; break;
                case "9": returnValue="115200"; break;
                default: returnValue = "115200"; break;
            }
            return returnValue;
        }
        private string changestop(string input)
        {
            string returnValue = "";
            switch (input)
            {
                case "1": returnValue = "0"; break;
                case "2": returnValue = "1"; break;
                default: returnValue = "1"; break;
            }
            return returnValue;
        }
        private string Revertstop(string input)
        {
            string returnValue = "";
            switch (input)
            {
                case "0": returnValue = "1"; break;
                case "1": returnValue = "2"; break;
                default: returnValue = "0"; break;
            }
            return returnValue;
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
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    setValue(receiveData);
                }));
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
                        this.comboBox2.SelectedItem =(ls.Split(':')[1].Trim());
                    }
                    else if (ls.StartsWith("COM1 Params"))
                    {
                        string values = ls.Split(':')[1].Trim();
                        if (values.Length == 3)
                        {
                            //数据位
                            comboBox11.SelectedItem = values[0].ToString();
                            //检验位
                            comboBox3.SelectedItem = RevertJyValue(values[1].ToString());
                            //停止位
                            comboBox4.SelectedItem = values[2].ToString();
                        }
                    }
                    else if (ls.StartsWith("Radio Speed"))
                    {
                        this.cbSpeed.SelectedItem = ls.Split(':')[1].Trim();
                    }
                    else if (ls.StartsWith("Sleep mode"))
                    {
                        this.comboBox5.SelectedItem = ls.Split(':')[1].Trim();
                    }
                    else if (ls.StartsWith("NSID"))
                    {
                        txtNetNumber.Text = ls.Split(':')[1].Trim();
                    }
                    else if (ls.StartsWith("Device Type"))
                    {
                        this.comboBox1.SelectedItem = RevertDeviceValue(ls.Split(':')[1].Trim());
                    }
                    else if (ls.StartsWith("Device ID"))
                    {
                        txtLocalId.Text = ls.Split(':')[1].Trim();
                    }
                    else if (ls.StartsWith("RF transmit Power"))
                    {
                        txtFsgl.Text = ls.Split(':')[1].Trim();
                    }
                    else if (ls.StartsWith("Trans Addr"))
                    {
                        txtTCId.Text = ls.Split(':')[1].Trim();
                    }
                    else if (ls.StartsWith("Relay Addr"))
                    {
                        txtZJId.Text = ls.Split(':')[1].Trim();
                    }
                    else if (ls.StartsWith("Frequency"))
                    {
                        txtPl.Text = ls.Split(':')[1].Trim();
                    }
                }
            }
        }

        private string GetJyValue(string s)
        {
            string value = "";
            switch (s)
            {
                case "None": value = "0"; break;
                case "Odd": value = "1"; break;
                case "Even": value = "2"; break;
                default: value = "0"; break;

            }
            return value;
        }

        private string RevertJyValue(string s)
        {
            string value = "";
            switch (s)
            {
                case "N": value = "None"; break;
                case "O": value = "Odd"; break;
                case "E": value = "Even"; break;
                default: value = "None"; break;

            }
            return value;
        }

        private string GetDeviceValue(string s)
        {
            string value = "";
            switch (s)
            {
                case "网关": value = "0"; break;
                case "中继器": value = "1"; break;
                case "终端": value = "2"; break;
                default: value = "2"; break;

            }
            return value;
        }

        private string RevertDeviceValue(string s)
        {
            string value = "";
            switch (s)
            {
                case "gateway": value = "网关"; break;
                case "relay": value = "中继器"; break;
                case "node": value = "终端"; break;
                default: value = "终端"; break;

            }
            return value;
        }

        //保存配置
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateNumber(txtNetNumber);
                ValidateNumber(txtLocalId);
                ValidateNumber(txtTCId);
                ValidateNumber(txtZJId);
                ValidateNumber(txtPl, 1);
                List<string> commands = GetCommand();
                foreach (string cmd in commands)
                {
                    bool result = SendData(cmd);
                    if (!result)
                    {
                        break;
                    }
                }
                SendData("AT+SAVE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //重启
        private void button4_Click(object sender, EventArgs e)
        {
            SendData("AT+RSET");
            this.cbLine.Checked = false;

        }

        //恢复出厂设置
        private void button5_Click(object sender, EventArgs e)
        {
            SendData("AT+FACT");
            SendData("AT+SHOW");
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
