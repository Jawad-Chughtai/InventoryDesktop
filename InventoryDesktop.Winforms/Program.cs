using Autofac;
using InventoryDesktop.Applications.Users;
using InventoryDesktop.EntityFramework;
using InventoryDesktop.Winforms.Forms;
using System.Configuration;

namespace InventoryDesktop.Winforms
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
                Startup.Run();
            
        }
    }
}