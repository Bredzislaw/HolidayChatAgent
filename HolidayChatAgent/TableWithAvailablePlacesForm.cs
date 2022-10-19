using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HolidayChatAgent
{
    public partial class HolidayDestinations : Form
    {
        //path to a csv file in Resources
        private string _destinationFilePath = "C:/Users/KamilDesktop/HolidayChatAgent/HolidayChatAgentResources/HolidayAgentData.csv";
        private DataTable csvData = new DataTable();
        private DataTable saveDestination = new DataTable();

        public HolidayDestinations()
        {
            InitializeComponent();
        }

        //When form load
        private void holidayDestinations_Load(object sender, EventArgs e)
        {

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
        private void holidayDestinations_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var selectedDestination = holidayDestinationGrid.Rows[e.RowIndex].Cells[5].Value;
        }

        private void AddCellToDataTable() 
        {
            DataTable dataTable = new DataTable();
           // DataColumn
        }
      //  }
    }
}
