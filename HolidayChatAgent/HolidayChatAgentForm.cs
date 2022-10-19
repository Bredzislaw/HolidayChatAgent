using HolidayChatAgent.Models;
using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.History;
using Telerik.WinForms.Controls.Spreadsheet.Dialogs;
using Telerik.WinForms.Documents.RichTextBoxCommands;

namespace HolidayChatAgent
{
    public partial class HolidayChatAgentForm : Form
    {
        //setting the properties for Author in a conversation
        private Author UserAuthor { get; set; }
        private Author BotAuthor { get; set; }

        //List of proposed actions 
        Dictionary<int,SuggestedActionDataItem> actions = new Dictionary<int,SuggestedActionDataItem>();
        Dictionary<string, string> sendedMessage = new Dictionary<string, string>();
        DataTable departureDate = new DataTable();

        //list of data with available holidays
        public static List<HolidayData> holidayInfors = new List<HolidayData>();
        
        //values selected by user, asked by bot 
        public static List<string> selectedValues = new List<string>();
        private static int questionNumber = 0;
        
        public HolidayChatAgentForm()
        {
            InitializeComponent();
            //declaring users and setting the avatars
            this.BotAuthor = new Author(Properties.Resources.FirstHolidayLtd, "First Holiday Ltd");
            this.UserAuthor = new Author(Properties.Resources.DefaultUser, "Kamil");

            mainRadChat.ChatElement.Author = UserAuthor;
        }

        //When form load
        private void HolidayChatAgentForm_Load(object sender, EventArgs e)
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
            // while()
            
                
                answerQuestion(textMessage);
                //DateTime? selectedDate = DateTime.Parse(((ChatTextMessage)e.Message).Message);           
                //questionNumber++;
        
            //.Clear();
            //nextQuestion();


            //TODO: add selected date to datatable/collection + the destination

            //if(textMessage == ChatOverlay
        }
        public void answerQuestion(ChatTextMessage textMessage) 
        {
            var userInput = "";
            userInput = textMessage.Message;
            if (questionNumber == 1)
            {                              
                if (ifValidValueTyped(userInput)) //ValidateCountry(userInput)
                {
                    selectedValues.Add($"Country: {userInput}");
                }
                else
                {                    
                    mainRadChat.AddMessage(sendMessage($"{userInput} is not valid. Try again.", BotAuthor, DateTime.Now));
                    return;
                }
            }
            else if (questionNumber == 2) //ValidateCity(userInput)
            {
                
                if (ifValidValueTyped(userInput))
                {                   
                    selectedValues.Add($"2:UserCity: {userInput}");
                }
                else
                {
                    mainRadChat.AddMessage(sendMessage($"{userInput} is not valid. Try again.", BotAuthor, DateTime.Now));
                    return;
                }
            }
            else if (questionNumber == 3)
            {
               
               // stringConverter(userInput);
                if (ifValidValueTyped(userInput))
                {
                    if (userInput is string)
                    {
                        selectedValues.Add($"3:Rating: {userInput}");
                    }
                }
                else
                {
                    mainRadChat.AddMessage(sendMessage($"{userInput} is not valid. Try again.", BotAuthor, DateTime.Now));
                    return;
                }
            }
            else if (questionNumber == 4)
            {
               
                if (ifValidValueTyped(userInput))
                {
                    selectedValues.Add($"4:Location: {userInput}");
                }
                else
                {
                    mainRadChat.AddMessage(sendMessage("Invalid rating name", BotAuthor, DateTime.Now));
                    return;
                }
            }
            else if (questionNumber == 5)
            {
               
                if (ifValidValueTyped(userInput))
                {
                    if (userInput is string)
                    {
                        //userInput.ToString();
                        selectedValues.Add($"3:Price: {userInput}");
                    }
                }
                else
                {
                    mainRadChat.AddMessage(sendMessage($"{userInput} is not valid. Try again.", BotAuthor, DateTime.Now));
                    return;
                }
            }
            askQuestion();
        }

        public void askQuestion() 
        {
            questionNumber++;
            if (questionNumber == 1)
            {
                mainRadChat.AddMessage(sendMessage("Agent: Enter a country you would like to visit?", BotAuthor, DateTime.Now));
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
        //public string stringConverter(string userInput) 
        //{
        //    var convertTyped = Convert.ToInt32(userInput);
        //    var convertToString = convertTyped.ToString();
        //    return convertToString;

        //}
        
        //Adding a carousel with suggested actions
        public void AddSuggestedActions() 
        {
       
                actions.Add(1,new SuggestedActionDataItem("Book a travel"));
                actions.Add(2,new SuggestedActionDataItem("Possible destinations"));
                actions.Add(3,new SuggestedActionDataItem("Go to the Summary"));
            
            
            ChatSuggestedActionsMessage suggestedActionsMessage = new ChatSuggestedActionsMessage(actions.Values, BotAuthor, DateTime.Now);
            //Select the suggested actions
            mainRadChat.AddMessage(suggestedActionsMessage);
            mainRadChat.SuggestedActionClicked += mainRadChat_SuggestedActionClicked;
            var suggestedAction = mainRadChat_SuggestedActionClicked;
        }

        private void mainRadChat_SuggestedActionClicked(object sender, SuggestedActionEventArgs e)
        {
            mainRadChat.AddMessage(new ChatTextMessage("You have chosen " + e.Action.Text, BotAuthor, DateTime.Now));
            if (e.Action.Text == "Book a travel")
            {
                this.mainRadChat.AddMessage(sendMessage("Select date of departure", BotAuthor, DateTime.Now));
                DepartureDate();

                TableWithAvailablePlacesForm availablePlacesForm = new TableWithAvailablePlacesForm();
                availablePlacesForm.Show();

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

        //private EventHandler chatCalendarOverlay_Click()
        //{
           
            
        //   ;
            
        //    var a = 0;
        //    return null;
        //}


        public static bool ifValidValueTyped(string type) 
        {
            bool validData = holidayInfors.Any(x => x.Country.Any() || x.Location.Any() || x.StarRating.Any() || x.City.Any());
            if (validData)
            {
                return true;
            }
            return false;
        }

        //public static bool validCountry(string country)
        //{
        //    foreach (var item in holidayInfors)
        //    {

        //        if (country.Equals(item.Country, StringComparison.OrdinalIgnoreCase))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
       
    }
}