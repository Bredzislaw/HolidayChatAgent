using HolidayChatAgent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidayChatAgent
{
    public partial class BookingPreview : Form
    {
        public HolidayData UserSelection = new HolidayData();

        public BookingPreview()
        {
            InitializeComponent();
        }

        private void ShowBookingDetails()
        {
            lblReferenceValue.Text = UserSelection.Country;
            lblHotelNameValue.Text = UserSelection.City;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You booking has been confirmed.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BookingPreview_Load(object sender, EventArgs e)
        {
            ShowBookingDetails();
        }
    }
}
