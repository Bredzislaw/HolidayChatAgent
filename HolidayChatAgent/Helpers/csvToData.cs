using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using TheArtOfDev.HtmlRenderer.Core;

namespace HolidayChatAgent.Helpers
{
    public class csvToData
    {
        public static DataTable GetDataTableFromCSVFile(string csv_file_path, DataTable table, RadGridView gridView)
        {

            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn dateColumn = new DataColumn(column);
                        dateColumn.AllowDBNull = true;
                        table.Columns.Add(dateColumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        table.Rows.Add(fieldData);
                        gridView.DataSource = table.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return table;
        }
    }
}
