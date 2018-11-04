﻿using LeafSoft.Lib;
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
            Control[] controls= DataReceiver.Controls.Find("rbtnHex",false);
            if (controls.Length > 0)
            {
                (controls[0] as RadioButton).Checked = true;
            }
            //dataGridView1.DataSource = new List<ShowData>();
        }

        List<ShowData> waterTemperature = new List<ShowData>();

        private void Configer_DataReceived(object sender, byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.AppendFormat("{0:x2}" + " ", data[i]);
            }
            string receiveData = sb.ToString();
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
                        this.tmpHigh.ReadOnly = true;
                        this.tmpLow.ReadOnly = true;
                        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                        if (showData.Type == "17")
                        {
                            int index = this.dataGridView1.Rows.Add();
                            this.dataGridView1.Rows[index].Cells[0].Value = showData.CreateTime;
                            this.dataGridView1.Rows[index].Cells[1].Value = showData.ZoneId;
                            this.dataGridView1.Rows[index].Cells[2].Value = showData.DeviceId;
                            this.dataGridView1.Rows[index].Cells[3].Value = GetTypeName(showData.Type);
                            this.dataGridView1.Rows[index].Cells[4].Value = showData.Value2+"℃";
                            this.dataGridView1.Rows[index].Cells[5].Value = showData.Value1+"%";
                            if (double.Parse(showData.Value2) < double.Parse(tmpLow.Text) || double.Parse(showData.Value2) > double.Parse(tmpHigh.Text))
                            {
                                showData.Status = "异常";
                                cellStyle.ForeColor=Color.Red;
                            }

                            else
                            {
                                showData.Status = "正常";
                                cellStyle.ForeColor = Color.Green;
                            }
                            this.dataGridView1.Rows[index].Cells[6].Value = showData.Status;
                            this.dataGridView1.Rows[index].Cells[6].Style = cellStyle;
                            this.dataGridView1.Rows[index].HeaderCell.Value = (index + 1).ToString();
                        }
                        else if (showData.Type == "32")
                        {
                            int index = this.dataGridView3.Rows.Add();
                            this.dataGridView3.Rows[index].Cells[0].Value = showData.CreateTime;
                            this.dataGridView3.Rows[index].Cells[1].Value = showData.ZoneId;
                            this.dataGridView3.Rows[index].Cells[2].Value = showData.DeviceId;
                            this.dataGridView3.Rows[index].Cells[3].Value = GetTypeName(showData.Type);
                            this.dataGridView3.Rows[index].Cells[4].Value = showData.Value1;
                            if (double.Parse(showData.Value1)==0)
                            {
                                showData.Status = "正常";
                                cellStyle.ForeColor = Color.Green;
                            }

                            else
                            {
                                showData.Status = "异常";
                                cellStyle.ForeColor = Color.Red;
                            }
                            this.dataGridView3.Rows[index].Cells[5].Value = showData.Status;
                            this.dataGridView3.Rows[index].HeaderCell.Value = (index + 1).ToString();
                        }
                       

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
            if (type == "17")
                return "温湿度采集器";
            if (type == "32")
                return "水浸采集器";
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

        private void exportTem_Click(object sender, EventArgs e)
        {

            exportData("温湿度",this.dataGridView1,"温湿度采集器结果");
        }

        private void exportWater_Click(object sender, EventArgs e)
        {
            exportData("水浸", this.dataGridView3, "水浸结果");
        }

        private void exportData(string fileName, DataGridView dv, string title)
        {
            string file = ExportExcel.ExportExcelData(fileName, dv, title);
            if (file.Length > 0)
            {
                MessageBox.Show("导出成功，路径：" + file);
            }
            else
            {
                MessageBox.Show("导出失败，路径：" + file);
            }
        }
    }
}
