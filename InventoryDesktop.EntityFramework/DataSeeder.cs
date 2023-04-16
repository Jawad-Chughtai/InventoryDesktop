using InventoryDesktop.EntityFramework.Users;
using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework
{
    public static class DataSeeder
    {
        public static async void SeedAsync()
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
                IsIncluded = true
            });

            await context.SaveChangesAsync();
        }
    }
}
