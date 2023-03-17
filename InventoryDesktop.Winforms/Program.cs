using InventoryDesktop.EntityFramework;
using InventoryDesktop.Winforms.Forms;
using Microsoft.EntityFrameworkCore;

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

            using (var context = new InventoryDbContext())
            {
                context.Database.EnsureCreated();
            }


            using var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                var mainForm = new MainForm
                {
                    _loggedInUser = loginForm.LoggedInUser
                };
                Application.Run(mainForm);
            }
        }
    }
}