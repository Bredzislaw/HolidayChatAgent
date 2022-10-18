using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace HolidayChatAgent
{
    public partial class HolidayChatAgentForm : Form
    {
        //setting the properties for Author in a conversation
        private Author UserAuthor { get; set; }
        private Author BotAuthor { get; set; }

        //List of proposed actions 
        Dictionary<int,SuggestedActionDataItem> actions = new Dictionary<int,SuggestedActionDataItem>();
        private int status = 0;

        public HolidayChatAgentForm()
        {
            InitializeComponent();
            //declaring users and setting the avatars
            this.BotAuthor = new Author(Properties.Resources.FirstHolidayLtd, "First Holiday Ltd");
            this.UserAuthor = new Author(Properties.Resources.DefaultUser, "Kamil");

            mainRadChat.ChatElement.Author = UserAuthor;
        }

        //First things first 
        private void HolidayChatAgentForm_Load(object sender, EventArgs e)
        {
            this.mainRadChat.AddMessage(sendMessage("Hello, welcome to the First Holiday Ltd.", BotAuthor, DateTime.Now));
            this.mainRadChat.AddMessage(sendMessage($"We are the leading brand for holiday packages. \r\n I will be happy to answer your questions.", BotAuthor, DateTime.Now));
            AddSuggestedActions();

        }

        public ChatMessage sendMessage(string message, Author author, DateTime time)
        {
            ChatTextMessage textMessage = new ChatTextMessage(message, author, time);
            return textMessage;
        }

        private void mainRadChat_SendMessage(object sender, SendMessageEventArgs e)
        {

            ChatTextMessage textMessage = (ChatTextMessage)e.Message;  
            //if(textMessage == ChatOverlay
        }

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

        private async void mainRadChat_SuggestedActionClicked(object sender, SuggestedActionEventArgs e)
        {
            mainRadChat.AddMessage(new ChatTextMessage("You have chosen " + e.Action.Text, BotAuthor, DateTime.Now));
            if (e.Action.Text == "Book a travel")
            {

                
                    this.mainRadChat.AddMessage(sendMessage("Select date of departure", BotAuthor, DateTime.Now));
                    await DepartureDate();
                    

                if (DepartureDate().IsCompleted)
                {
                    TableWithAvailablePlacesForm availablePlacesForm = new TableWithAvailablePlacesForm();
                    availablePlacesForm.Show();
                }
            }
            if (e.Action.Text == "Possible destinations") 
            {
                
            };
            
        }
        //Calendar
        public async Task DepartureDate() 
        {
            ChatCalendarOverlay chatCalendarOverlay = new ChatCalendarOverlay("Set a date of your departure");
            //Disable previous days
            chatCalendarOverlay.Calendar.RangeMinDate = DateTime.Now.AddDays(1);
            bool showAsPopup = false;
            ChatOverlayMessage overlayMessage = new ChatOverlayMessage(chatCalendarOverlay, showAsPopup, BotAuthor, DateTime.Now);
            mainRadChat.AddMessage(overlayMessage);
           
        }

       
    }
}