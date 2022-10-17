using ExcelDataReader;
using HolidayChatAgent.Models;
using HolidayChatAgent.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChatAgent.Helpers
{
    internal class ImportExcelToDB
    {
        public void ImportExcel() 
        {
            DataTableCollection tableCollection;

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var dataSource = "C:/Users/Kamil/source/repos/HolidayChatAgent/HolidayChatAgent/Resources/";
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tableCollection = result.Tables;                          
                           // foreach (DataTable table in tableCollection)
                              //  cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }
    }
}
