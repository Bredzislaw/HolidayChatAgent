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
using HolidayChatAgent.Models;

namespace HolidayChatAgent
{
    public partial class TableWithAvailablePlacesForm : Form
    {
        public HolidayData UserAnswers = new HolidayData();
        public List<HolidayData> AvailableDestinations = new List<HolidayData>();

        public TableWithAvailablePlacesForm()
        {
            InitializeComponent();            
        }

        private void FilterDestination()
        {
            List<HolidayData> matchingDestination = AvailableDestinations.Where( dest =>  
                dest.Country == UserAnswers.Country &&
                dest.City == UserAnswers.City
                ).ToList();
            holidayDestinationGrid.DataSource = matchingDestination;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            BookingPreview bookingPreview = new BookingPreview();
            bookingPreview.UserSelection = UserAnswers; //TODO - instead of UserAnswer, you need to pass SelectedItem from GridView
            bookingPreview.Show();
        }

        private void TableWithAvailablePlacesForm_Load(object sender, EventArgs e)
        {
            FilterDestination();
        }
    }
}