using InventoryDesktop.EntityFramework.Users;
using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework
{
    public static class DataSeeder
    {
        public static async void SeedAsync()
        {
            try
            {
                var context = new InventoryDbContext();

                var any = await context.Users.AnyAsync();
                if (any)
                {
                    return;
                }

                context.Users.AddRange(new User
                {
                    FirstName = "Super",
                    LastName = "Admin",
                    Username = "superadmin",
                    Password = "Admin123?",
                    Role = "SuperAdmin",
                    IsIncluded = false
                }, new User
                {
                    FirstName = "Muhammad",
                    LastName = "Ayaz",
                    Username = "admin",
                    Password = "admin",
                    Role = "Admin",
                    IsIncluded = false
                });

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                // Create the full path for the text file
                string filePath = Path.Combine(desktopPath, "logs.txt");

                using StreamWriter sw = File.AppendText(filePath);
                sw.WriteLine(DateTime.Now.ToString() + ex);

            }
        }
    }
}
