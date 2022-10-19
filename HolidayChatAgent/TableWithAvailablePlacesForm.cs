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
using Microsoft.VisualBasic.FileIO;
using Telerik.WinControls.UI;
using HolidayChatAgent.Helpers;
namespace HolidayChatAgent
{
    public partial class TableWithAvailablePlacesForm : Form
    {
        private string _destinationsFilePath = "C:/Users/kborkows/Desktop/New folder/HolidayChatAgent/HolidayChatAgent/Resources/HolidayAgentData.csv";
        public DataTable csvData = new DataTable();
       // private DataTable savedDestination = new DataTable();
        public TableWithAvailablePlacesForm()
        {
            InitializeComponent();
            
        }

        private void holidayDestinations_Load(object sender, EventArgs e)
        {
            
            csvToData.GetDataTableFromCSVFile(_destinationsFilePath,csvData,holidayDestinationGrid);
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

        //private void AddDataToDGV()
        //{
        //    DataTable dataTable = new DataTable();
        //    //create some columns for the datatable
        //    DataColumn dc = new DataColumn("HolidayReference");
        //    DataColumn dc2 = new DataColumn("HotelName");
        //    DataColumn dc3 = new DataColumn("City");
        //    DataColumn dc4 = new DataColumn("Continent");
        //    DataColumn dc5 = new DataColumn("Country");
        //    DataColumn dc6 = new DataColumn("Category");
        //    DataColumn dc7 = new DataColumn("StarRating");
        //    DataColumn dc8 = new DataColumn("TempRating");
        //    DataColumn dc9 = new DataColumn("Location");
        //    DataColumn dc10 = new DataColumn("PricePerNight");
        //    //add the columns to the datatable
        //    dataTable.Columns.Add(dc);
        //    dataTable.Columns.Add(dc2);
        //    dataTable.Columns.Add(dc3);
        //    dataTable.Columns.Add(dc4);
        //    dataTable.Columns.Add(dc5);
        //    dataTable.Columns.Add(dc6);
        //    dataTable.Columns.Add(dc7);
        //    dataTable.Columns.Add(dc8);
        //    dataTable.Columns.Add(dc9);
        //    dataTable.Columns.Add(dc10);
        //    for (int i = 0; i <= 10; i++)
        //    {
        //        DataRow dataRow = dataTable.NewRow();//create a new row based on the existing "row model"
        //        dataRow["I"] = "Item" + "Name";
        //        dataRow["ItemValue"] = "Item" + i + "Value";
        //        dataRow["Blah"] = "Item" + i + "Blah";
        //        dataRow["Bleh"] = "Item" + i + "Bleh";
        //        dataTable.Rows.Add(dataRow);//add the row to the DataTable
        //    }


        //}
    }
}

