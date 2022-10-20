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
using Telerik.WinControls.VirtualKeyboard;

namespace HolidayChatAgent
{
    public partial class FilteredHolidayDestinationsForm : Form
    {
        public HolidayData UserAnswers = new HolidayData();
        public HolidayData UserSelection = new HolidayData();
        public List<HolidayData> AvailableDestinations = new List<HolidayData>();

        public FilteredHolidayDestinationsForm()
        {
            InitializeComponent();
            // holidayDestinationGrid.
            holidayDestinationGrid.MultiSelect = true;
            holidayDestinationGrid.SelectionMode = GridViewSelectionMode.FullRowSelect;
        }

        private void FilterDestination()
        {
            List<HolidayData> matchingDestination = AvailableDestinations.Where(dest =>
                 dest.Country == UserAnswers.Country &&
                 dest.City == UserAnswers.City
                 ).ToList();
            holidayDestinationGrid.DataSource = matchingDestination;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HolidayChatAgentForm holidayChatAgentForm = new HolidayChatAgentForm();
            holidayChatAgentForm.Refresh();
            holidayChatAgentForm.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            BookingPreview bookingPreview = new BookingPreview();
            
            bookingPreview.UserSelection = UserSelection;
            bookingPreview.Show();
            this.Close();
        }

        private void TableWithAvailablePlacesForm_Load(object sender, EventArgs e)
        {
            FilterDestination();
        }

        private void holidayDestinations_SelectionChanged(object sender, EventArgs e)
        {
            if (holidayDestinationGrid.CurrentRow is not null)
            {
                UserSelection = (HolidayData)holidayDestinationGrid.CurrentRow.DataBoundItem;
            }
        }
    }
}
