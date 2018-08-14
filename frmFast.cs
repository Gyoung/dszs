using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft
{
    public partial class frmFast : Form
    {
        public frmFast()
        {
            InitializeComponent();
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
                    SendData(cmd);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
            if (txtNetNumber.Text.Length > 0)
            {
                
            }
        }


        private void SendData(string cmd)
        {
            string line = cmd + "\r\n"; //增加换行
            byte[] data = new ASCIIEncoding().GetBytes(line);
            if (Configer.SendData(data) == true)
            {

            }
        }


        private List<string> GetCommand()
        {
            List<string> commands = new List<string>();
            commands.Add("+ATM");
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
                    if (combobox.SelectedValue != null&&combobox.Tag!=null)
                    {
                        commands.Add(combobox.Tag + combobox.SelectedValue.ToString());
                    }
                }

            }
            return commands;

        }


        private void ValidateNumber(TextBox textbox,int type=0)
        {
            int number=0;
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
                throw new Exception("请输入数值类型");
            }
              
        }

        private void Configer_DataReceived(object sender, byte[] data)
        {

        }
    }
}
