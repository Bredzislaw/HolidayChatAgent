using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HolidayChatAgent
{
    internal static class Program
    {
        public static HolidayChatAgentForm MainForm { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().RunAsync();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new HolidayChatAgentForm();
            Application.Run(new HolidayChatAgentForm());
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
             WebHost.CreateDefaultBuilder(args)
                 .UseStartup<Startup>();
    }
}