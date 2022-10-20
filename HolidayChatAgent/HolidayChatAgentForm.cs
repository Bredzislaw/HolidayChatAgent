using HolidayChatAgent.Helpers;
using HolidayChatAgent.Models;
using System.Data;
using System.Linq;
using Telerik.WinControls.UI;

namespace HolidayChatAgent
{
    public partial class HolidayChatAgentForm : Form
    {
        //setting the properties for Author in a conversation
        private Author UserAuthor { get; set; }
        private Author BotAuthor { get; set; }

        //List of proposed actions 
        Dictionary<int, SuggestedActionDataItem> actions = new Dictionary<int, SuggestedActionDataItem>();
        Dictionary<string, string> sendedMessage = new Dictionary<string, string>();
        DataTable departureDate = new DataTable();

        //list of data with available holidays
        public static List<HolidayData> holidayInfors = new List<HolidayData>();

        //values selected by user, asked by bot 
        private static int questionNumber = 0;


        public HolidayData UserAnswers = new HolidayData();
        public readonly List<HolidayData> AvailableDestinations = new List<HolidayData>();


        public HolidayChatAgentForm()
        {
            InitializeComponent();
            //declaring users and setting the avatars
            this.BotAuthor = new Author(Properties.Resources.FirstHolidayLtd, "First Holiday Ltd");
            this.UserAuthor = new Author(Properties.Resources.DefaultUser, "Kamil");

            mainRadChat.ChatElement.Author = UserAuthor;
            questionNumber = 0;
            AvailableDestinations = PopulateAvailableDestinations();
        }

        private List<HolidayData> PopulateAvailableDestinations()
        {
            string destinationsFilePath = "C:/Users/kborkows/Desktop/New folder/HolidayChatAgent/HolidayChatAgent/Resources/HolidayAgentData.csv"; //todo> set as config
            DataTable dtDestinations = CsvToDataTableConverter.GetDataTableFromCSVFile(destinationsFilePath);
            List<HolidayData> availableDestinations = new List<HolidayData>();

            foreach (DataRow row in dtDestinations.Rows)
            {
                var destination = new HolidayData()
                {
                    HolidayReference = Convert.ToString(row[0].ToString()),
                    HotelName = row[1].ToString(),
                    City = row[2].ToString(),
                    Continent = row[3].ToString(),
                    Country = row[4].ToString(),
                    Category = row[5].ToString(),
                    StarRating = Convert.ToInt32(row[6].ToString()),
                    TempRating = row[7].ToString(),
                    Location = row[8].ToString(),
                    PricePerNight = Convert.ToDecimal(row[9].ToString()),
                };

                availableDestinations.Add(destination);
            }

            return availableDestinations;
        }

        //When form load
        public void HolidayChatAgentForm_Load(object sender, EventArgs e)
        {
            welcomeMessage();

            AddSuggestedActions();

        }

        private void welcomeMessage()
        {
            mainRadChat.AddMessage(sendMessage($"Hello, welcome to the First Holiday Ltd.", BotAuthor, DateTime.Now));
            mainRadChat.AddMessage(sendMessage($"We are the leading brand for holiday packages. \r\n I will be happy to answer your questions.", BotAuthor, DateTime.Now));
            askQuestion();
        }

        public ChatMessage sendMessage(string message, Author author, DateTime time)
        {
            ChatTextMessage textMessage = new ChatTextMessage(message, author, time);
            return textMessage;
        }

        private void mainRadChat_SendMessage(object sender, SendMessageEventArgs e)
        {
            ChatTextMessage textMessage = (ChatTextMessage)e.Message;         
            answerQuestion(textMessage);         
        }

        public void answerQuestion(ChatTextMessage textMessage)
        {
            var userInput = "";
            userInput = textMessage.Message;

            if (questionNumber == 1)
            {
                if (!ValidateTypeCountry(userInput))
                {
                    mainRadChat.AddMessage(sendMessage($"{userInput} is not a valid country. Try again.", BotAuthor, DateTime.Now));
                    return;
                }

                if (!ValidateCountryIsAvailable(userInput))
                {
                    mainRadChat.AddMessage(sendMessage($"The country {userInput} currently is not available. Try again.", BotAuthor, DateTime.Now));
                    return;
                }

                UserAnswers.Country = userInput;
            }
            else if (questionNumber == 2)
            {

                if (!ValidateTypeCity(userInput))
                {
                    mainRadChat.AddMessage(sendMessage($"{userInput} is not a valid city. Try again.", BotAuthor, DateTime.Now));
                    return;
                }

                if (!ValidateCityIsAvailable(userInput))
                {
                    mainRadChat.AddMessage(sendMessage($"The city {userInput} currently is not available. Try again.", BotAuthor, DateTime.Now));
                    return;
                }

                UserAnswers.City = userInput;
            }
            else if (questionNumber == 3)
            {

                if (!ValidateTypeRating(userInput))
                {
                    mainRadChat.AddMessage(sendMessage($"{userInput} is not a valid rating. Try again.", BotAuthor, DateTime.Now));
                    return;
                }

                if (!ValidateRatingIsAvailable(userInput))
                {
                    mainRadChat.AddMessage(sendMessage($"The rating {userInput} currently is not available. Try again.", BotAuthor, DateTime.Now));
                    return;
                }

                UserAnswers.StarRating = Convert.ToInt32(userInput);
            }
            else if (questionNumber == 4)
            {

                if (!ValidateTypeLocation(userInput))
                {
                    mainRadChat.AddMessage(sendMessage($"{userInput} is not a valid location. Try again.", BotAuthor, DateTime.Now));
                    return;
                }

                if (!ValidateLocationIsAvailable(userInput))
                {
                    mainRadChat.AddMessage(sendMessage($"The location {userInput} currently is not available. Try again.", BotAuthor, DateTime.Now));
                    return;
                }

                UserAnswers.Location = userInput;
            }
            else if (questionNumber == 5)
            {
                if (!ValidateTypePrice(userInput))
                {
                    mainRadChat.AddMessage(sendMessage($"{userInput} is not a valid price. Try again.", BotAuthor, DateTime.Now));
                    return;
                }

                if (!ValidatePriceIsAvailable(userInput))
                {
                    mainRadChat.AddMessage(sendMessage($"The price {userInput} currently is not available. Try again.", BotAuthor, DateTime.Now));
                    return;
                }

                UserAnswers.PricePerNight = Convert.ToDecimal(userInput);
                this.mainRadChat.AddMessage(sendMessage("Searching for destinations available...", BotAuthor, DateTime.Now));

                Thread.Sleep(3000);
                ShowFilteredDestination();
            }

            askQuestion();
            
        }

        private bool ValidateTypeCountry(string userInput)
        {
            bool isAnswerTypeValid = false;
            isAnswerTypeValid = int.TryParse(userInput, out _);

            return !isAnswerTypeValid;
        }

        private bool ValidateCountryIsAvailable(string userInput)
        {
            bool isCountryAvailable = false;
            isCountryAvailable = AvailableDestinations.Where(dest => dest.Country.Equals(userInput, StringComparison.InvariantCultureIgnoreCase)).Count() > 0;

            return isCountryAvailable;
        }
        private bool ValidateTypeCity(string userInput)
        {
            bool isAnswerTypeValid = false;
            isAnswerTypeValid = int.TryParse(userInput, out _);

            return !isAnswerTypeValid;
        }

        private bool ValidateCityIsAvailable(string userInput)
        {
            bool isCityAvailable = false;
            isCityAvailable = AvailableDestinations.Where(dest => dest.City == userInput).Count() > 0;

            return isCityAvailable;
        }
        private bool ValidateTypeRating(string userInput)
        {
            bool isAnswerTypeValid = false;
            isAnswerTypeValid = int.TryParse(userInput, out _);

            return isAnswerTypeValid;
        }
        private bool ValidateRatingIsAvailable(string userInput)
        {
            bool isRatingAvailable = false;
            isRatingAvailable = AvailableDestinations.Where(dest => dest.StarRating == Convert.ToInt32(userInput)).Count() > 0;

            return isRatingAvailable;
        }

        private bool ValidateTypeLocation(string userInput)
        {
            bool isAnswerTypeValid = false;
            isAnswerTypeValid = int.TryParse(userInput, out _);

            return !isAnswerTypeValid;
        }

        private bool ValidateLocationIsAvailable(string userInput)
        {
            bool isLocationAvailable = false;
            isLocationAvailable = AvailableDestinations.Where(dest => dest.Location == userInput).Count() > 0;

            return isLocationAvailable;
        }
        private bool ValidateTypePrice(string userInput)
        {
            bool isAnswerTypeValid = false;
            isAnswerTypeValid = decimal.TryParse(userInput, out _);

            return isAnswerTypeValid;
        }

        private bool ValidatePriceIsAvailable(string userInput)
        {
            bool isPriceAvailable = false;
            isPriceAvailable = AvailableDestinations.Where(dest => dest.PricePerNight == Convert.ToDecimal(userInput)).Count() > 0;

            return isPriceAvailable;
        }

        public void askQuestion()
        {
            questionNumber++;
            if (questionNumber == 1)
            {
                mainRadChat.AddMessage(sendMessage("Enter a country you would like to visit?", BotAuthor, DateTime.Now));
            }
            else if (questionNumber == 2)
            {
                mainRadChat.AddMessage(sendMessage("Enter a city name", BotAuthor, DateTime.Now));
            }
            else if (questionNumber == 3)
            {
                mainRadChat.AddMessage(sendMessage("Enter a hotel rating", BotAuthor, DateTime.Now));
            }
            else if (questionNumber == 4)
            {
                mainRadChat.AddMessage(sendMessage("Enter a country type. Chose from(CITY,MOUNTAIN,SEA)", BotAuthor, DateTime.Now));
            }
            else if (questionNumber == 5)
            {
                mainRadChat.AddMessage(sendMessage("Enter an overall cost", BotAuthor, DateTime.Now));
            }

        }
        //Adding a carousel with suggested actions
        public void AddSuggestedActions()
        {

           // actions.Add(1, new SuggestedActionDataItem("Book a travel"));
          //  actions.Add(2, new SuggestedActionDataItem("Possible destinations"));
          //  actions.Add(3, new SuggestedActionDataItem("Go to the Summary"));


            ChatSuggestedActionsMessage suggestedActionsMessage = new ChatSuggestedActionsMessage(actions.Values, BotAuthor, DateTime.Now);
          
            //Select the suggested actions
            mainRadChat.AddMessage(suggestedActionsMessage);
            mainRadChat.SuggestedActionClicked += mainRadChat_SuggestedActionClicked;
            var suggestedAction = mainRadChat_SuggestedActionClicked;
        }

        private void ShowFilteredDestination()
        {
            questionNumber = 0;
            FilteredHolidayDestinationsForm availablePlacesForm = new FilteredHolidayDestinationsForm();
            availablePlacesForm.AvailableDestinations.AddRange(AvailableDestinations);
            availablePlacesForm.UserAnswers = UserAnswers;
            availablePlacesForm.Show();
            //mainRadChat.Dispose();
            this.Hide();
        }

        private void mainRadChat_SuggestedActionClicked(object sender, SuggestedActionEventArgs e)
        {
            mainRadChat.AddMessage(new ChatTextMessage("You have chosen " + e.Action.Text, BotAuthor, DateTime.Now));
            if (e.Action.Text == "Book a travel")
            {
                this.mainRadChat.AddMessage(sendMessage("Select date of departure", BotAuthor, DateTime.Now));
              //  DepartureDate();

                

            }
            
            if (e.Action.Text == "Possible destinations")
            {
                PossibleDestinations possibleDestinations = new PossibleDestinations();
                possibleDestinations.Show();
            };

        }
        //Calendar
        public void DepartureDate()
        {
            ChatCalendarOverlay chatCalendarOverlay = new ChatCalendarOverlay("Set a date of your departure");
            //Disable previous days
            chatCalendarOverlay.Calendar.RangeMinDate = DateTime.Now.AddDays(1);
            //chatCalendarOverlay.Calendar.CalendarElement.Click += chatCalendarOverlay_Click();                      
            bool showAsPopup = false;
            ChatOverlayMessage overlayMessage = new ChatOverlayMessage(chatCalendarOverlay, showAsPopup, BotAuthor, DateTime.Now);
            mainRadChat.AddMessage(overlayMessage);

        }
        //public static bool ifValidValueTyped(string type)
        //{
        //    return false;
        //}    
    }
}