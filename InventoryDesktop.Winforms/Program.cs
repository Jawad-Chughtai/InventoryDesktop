using InventoryDesktop.Winforms.Forms;

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