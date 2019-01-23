using NPOI.HSSF.UserModel;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LeafSoft.Lib
{
    public class ExportExcel
    {
        public static string ExportExcelData(string fileName,DataGridView dgv, string title)
        {
            try
            {
                //创建主要对象
                HSSFWorkbook workbook = new HSSFWorkbook();
                HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet("Weight");
                //设置字体，大小，对齐方式
                HSSFCellStyle style = (HSSFCellStyle)workbook.CreateCellStyle();
                HSSFFont font = (HSSFFont)workbook.CreateFont();
                //font.FontName = fontname;
                //font.FontHeightInPoints = fontsize;
                style.SetFont(font);
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER; //居中对齐


                HSSFRow dataRow = null;
                //添加表头说明
                dataRow = (HSSFRow)sheet.CreateRow(0);
                dataRow.CreateCell(0).SetCellValue(title);
                sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, dgv.Columns.Count - 1));

                //设置标题居中
                dataRow.GetCell(0).CellStyle = style;


                //添加表头
                dataRow = (HSSFRow)sheet.CreateRow(1);

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    dataRow.CreateCell(i).SetCellValue(dgv.Columns[i].HeaderText);
                    dataRow.GetCell(i).CellStyle = style;
                }
                //添加列及内容
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    dataRow = (HSSFRow)sheet.CreateRow(i + 2);
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        object value = dgv.Rows[i].Cells[j].Value;
                        if (value != null)
                        {
                            dataRow.CreateCell(j).SetCellValue(value.ToString());
                        }
                        else
                        {
                            dataRow.CreateCell(j).SetCellValue("");
                        }

                        dataRow.GetCell(j).CellStyle = style;
                        //设置宽度
                        //sheet.SetColumnWidth(j, (Value.Length + 15) * 256);
                    }
                }
                //保存文件
                string dir = AppDomain.CurrentDomain.BaseDirectory + "ReceiveData";
                if (Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                string saveFileName = dir + "/"+fileName + DateTime.Now.ToString("yyyyMMddHHssmm") + ".xls";
                using (FileStream file = new FileStream(saveFileName, FileMode.Create))
                {
                    workbook.Write(file);
                    workbook = null;
                }
                return saveFileName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
