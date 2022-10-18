using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolidayChatAgent.Helpers;
using Microsoft.VisualBasic.FileIO;
using Telerik.WinControls.UI;

namespace HolidayChatAgent
{
    public partial class TableWithAvailablePlacesForm : Form
    {
        private string _destinationsFilePath = "C:/Users/kborkows/Desktop/New folder/HolidayChatAgent/HolidayChatAgent/Resources/HolidayAgentData.csv";
        private DataTable csvData = new DataTable();
        private DataTable savedDestination = new DataTable();
        public TableWithAvailablePlacesForm()
        {
            InitializeComponent();
            
        }

        private void holidayDestinations_Load(object sender, EventArgs e)
        {
            
            GetDataTableFromCSVFile(_destinationsFilePath);
        }
        public DataTable GetDataTableFromCSVFile(string csv_file_path)
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
                        holidayDestinationGrid.DataSource = csvData.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return csvData;
        }

        private void holidayDestinationsForm_Click(object sender, EventArgs e)
        {
           
        }

        private void holidayDestinations_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
           var selectedDestination = holidayDestinationGrid.Rows[e.RowIndex].Cells[5].Value;
            
                //for (int i = 0; i <= holidayDestinationGrid.Rows[e.RowIndex].Cells.Count; i++)
                //{

                //    savedDestination.Rows.Add(holidayDestinationGrid.Rows[e.RowIndex].Cells[i].Value);
                //}
                
            
        }

        private void AddDataToDGV()
        {
            DataTable dataTable = new DataTable();
            //create some columns for the datatable
            DataColumn dc = new DataColumn("HolidayReference");
            DataColumn dc2 = new DataColumn("HotelName");
            DataColumn dc3 = new DataColumn("City");
            DataColumn dc4 = new DataColumn("Continent");
            DataColumn dc5 = new DataColumn("Country");
            DataColumn dc6 = new DataColumn("Category");
            DataColumn dc7 = new DataColumn("StarRating");
            DataColumn dc8 = new DataColumn("TempRating");
            DataColumn dc9 = new DataColumn("Location");
            DataColumn dc10 = new DataColumn("PricePerNight");
            //add the columns to the datatable
            dataTable.Columns.Add(dc);
            dataTable.Columns.Add(dc2);
            dataTable.Columns.Add(dc3);
            dataTable.Columns.Add(dc4);
            dataTable.Columns.Add(dc5);
            dataTable.Columns.Add(dc6);
            dataTable.Columns.Add(dc7);
            dataTable.Columns.Add(dc8);
            dataTable.Columns.Add(dc9);
            dataTable.Columns.Add(dc10);
            //create 5 rows of irrelevant information
            //this is the actual answer to your question
            for (int i = 0; i <= 10; i++)
            {
                DataRow dataRow = dataTable.NewRow();//create a new row based on the existing "row model"
                dataRow["ItemName"] = "Item" + "Name";
                dataRow["ItemValue"] = "Item" + i + "Value";
                dataRow["Blah"] = "Item" + i + "Blah";
                dataRow["Bleh"] = "Item" + i + "Bleh";
                dataTable.Rows.Add(dataRow);//add the row to the DataTable
            }


        }
    }
}

