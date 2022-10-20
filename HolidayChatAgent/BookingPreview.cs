using HolidayChatAgent.Models;

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
            lblReferenceValue.Text = UserSelection.HolidayReference;
            lblHotelNameValue.Text = UserSelection.HotelName;
            lblCityValue.Text = UserSelection.City;
            lblContinentValue.Text = UserSelection.Continent;
            lblCountryValue.Text = UserSelection.Country;
            lblCategoryValue.Text = UserSelection.Category;
            lblStarRatingValue.Text = UserSelection.StarRating.ToString();
            lblTempRatingValue.Text = UserSelection.TempRating;
            lblLocationValue.Text = UserSelection.Location;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HolidayChatAgentForm firstForm = new HolidayChatAgentForm();
            firstForm.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You booking has been confirmed.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(0);
        }

        private void BookingPreview_Load(object sender, EventArgs e)
        {
            ShowBookingDetails();
        }
    }
}
