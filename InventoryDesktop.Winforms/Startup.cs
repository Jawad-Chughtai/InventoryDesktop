using Autofac;
using InventoryDesktop.Applications.Users;
using InventoryDesktop.EntityFramework;
using InventoryDesktop.Winforms.Forms;
using System.Configuration;

namespace InventoryDesktop.Winforms
{
    public static class Startup
    {
        public static void Run()
        {
            try
            {
                //ConnectionSettings.ConnectionString = ConfigurationManager.ConnectionStrings["LocalDb"].ConnectionString;
                //DataSeeder.SeedAsync();

                var container = Container.Configure();

                using var scope = container.BeginLifetimeScope();

                using var loginForm = new LoginForm(scope.Resolve<IUserService>());

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    using (var mainFormScope = scope.BeginLifetimeScope())
                    {
                        var mainForm = mainFormScope.Resolve<MainForm>(
                                        new NamedParameter("loggedInUser", loginForm.LoggedInUser),
                                        new NamedParameter("container", container));
                        Application.Run(mainForm);
                    };
                }
            }
            catch (Exception ex)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                // Create the full path for the text file
                string filePath = Path.Combine(desktopPath, "logs.txt");

                using StreamWriter sw = new(filePath, true);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("----------- Start of Exception -----------");
                sw.WriteLine();
                sw.WriteLine(ex);
                sw.WriteLine();
                sw.WriteLine("----------- End of Exception -----------");
                sw.WriteLine();
            }
        }
    }
}
