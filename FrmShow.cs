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
            //dataGridView1.DataSource = new List<ShowData>();
        }

        List<ShowData> waterTemperature = new List<ShowData>();

        private void Configer_DataReceived(object sender, byte[] data)
        {
            string receiveData=new ASCIIEncoding().GetString(data);
            if (receiveData != null)
            {
                string[] datas = receiveData.Split(' ');
                if (datas.Length >8)
                {
                    ShowData showData = new ShowData();
                    showData.CreateTime = DateTime.Now.ToString();
                    showData.ZoneId = Convert.ToInt32(datas[1], 16).ToString();
                    showData.DeviceId = Convert.ToInt32(datas[2], 16).ToString();
                    showData.Type = Convert.ToInt32(datas[5], 16).ToString();
                    showData.Value1 = Convert.ToInt32(datas[6]+datas[7], 16).ToString();
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
                        int index = this.dataGridView1.Rows.Add();
                        this.dataGridView1.Rows[index].Cells[0].Value = showData.CreateTime;
                        this.dataGridView1.Rows[index].Cells[1].Value = showData.ZoneId;
                        this.dataGridView1.Rows[index].Cells[2].Value = showData.DeviceId;
                        this.dataGridView1.Rows[index].Cells[3].Value = GetTypeName(showData.Type);
                        this.dataGridView1.Rows[index].Cells[4].Value = showData.Value1;
                        this.dataGridView1.Rows[index].Cells[5].Value = showData.Value2;
                        this.dataGridView1.Rows[index].Cells[6].Value = showData.Status;
                        

                    }));
                   
                }
            }
           
            DataReceiver.AddData(data, false);
            MDataCounter.PlusReceive(data.Length);
        }

        private void FrmShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configer.ClearSelf();
        }

        /// <summary>
        /// 获取设备中文名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private string GetTypeName(string type)
        {
            if (type == "11")
                return "温湿度采集器";
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
    }
}
