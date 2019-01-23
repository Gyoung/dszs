using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace LeafSoft
{
    partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
            this.Text = string.Format("关于 {0}", Lib.AppInfor.AssemblyProduct);
            this.label1.Text = string.Format("产品名称: {0}", Lib.AppInfor.AssemblyProduct);
            this.label2.Text = string.Format("版本: {0}", Lib.AppInfor.AssemblyVersion);
            this.label4.Text = string.Format("问题反馈: {0}", Lib.AppInfor.AssemblyCompany);
            this.textBoxDescription.Text = Lib.AppInfor.AssemblyDescription;
        }
    }
}
