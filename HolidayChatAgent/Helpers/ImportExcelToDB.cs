using ExcelDataReader;
using HolidayChatAgent.Models;
using HolidayChatAgent.Properties;
using Microsoft.VisualBasic.FileIO;
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
        public static DataTable GetDataTableFromCSVFile(string csv_file_path)
        {
           DataTable csvData = new DataTable();
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
                        csvData.Columns.Add(dateColumn);
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
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)             
            {
                return null;
            }  
            return csvData;
            }
        }
    }

