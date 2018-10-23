using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft
{
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }

        private void Configer_DataReceived(object sender, byte[] data)
        {
            DataReceiver.AddData(data, false);
            MDataCounter.PlusReceive(data.Length);
        }

        private void FrmShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configer.ClearSelf();
        }
    }
}
