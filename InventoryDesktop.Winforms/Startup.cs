using Autofac;
using InventoryDesktop.Applications.Users;
using InventoryDesktop.EntityFramework;
using InventoryDesktop.Winforms.Forms;
using Serilog;
using System.Configuration;

namespace InventoryDesktop.Winforms
{
    public static class Startup
    {
        public static void Run()
        {
            try
            {
                Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.File("Logs\\log.txt", rollingInterval: RollingInterval.Day)
                            .CreateLogger();
                Log.Information("Application started.");

                //ConnectionSettings.ConnectionString = ConfigurationManager.ConnectionStrings["LocalDb"].ConnectionString;
                //DataSeeder.SeedAsync();

                Log.Information(ConnectionSettings.ConnectionString);

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
                Log.Fatal(ex.ToString());
                Log.CloseAndFlush();
            }
        }
    }
}
