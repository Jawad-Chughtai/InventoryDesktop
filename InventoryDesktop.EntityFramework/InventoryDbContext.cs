using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.ItemTypes;
using InventoryDesktop.EntityFramework.Users;
using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Initial Catalog=InventoryDesktop;Integrated Security=True;MultipleActiveResultSets=true;Trusted_Connection=true;TrustServerCertificate=True");
        }
    }
}
