using InventoryDesktop.Applications.Users;
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

            context.Users.Add(new User
            {
                FirstName = "Super",
                LastName = "Admin",
                Username = "admin",
                Password = UserService.HashPassword("admin"),
                Role = "SuperAdmin",
                IsIncluded = false
            });

            await context.SaveChangesAsync();
        }
    }
}
