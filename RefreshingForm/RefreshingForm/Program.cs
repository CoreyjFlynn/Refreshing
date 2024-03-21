using System;
using System.ServiceProcess;
using System.Windows.Forms;

namespace RefreshingForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "service")
            {
                //runs service;
                ServiceBase.Run(new[]
                {
                    new RefreshService()
                });
            }
            else
            {
                // runs GUI application
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new RefreshingForm());
            }
        }
    }
}
