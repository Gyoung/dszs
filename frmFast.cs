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
                Control.ControlCollection controls= groupBox3.Controls;
                foreach (Control item in controls)
                {
                    
                }


            }
            catch (Exception)
            {
                
                throw;
            }
            
           
            if (txtNetNumber.Text.Length > 0)
            {
                
            }
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
    }
}
