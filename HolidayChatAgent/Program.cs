using Telerik.WinControls.UI.Barcode;

namespace HolidayChatAgent
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            HolidayChatAgentForm chatAgentForm = new HolidayChatAgentForm();
            chatAgentForm.Show();
            Application.Run();
        }
    }
}