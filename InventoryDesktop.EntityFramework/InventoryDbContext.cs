using InventoryDesktop.EntityFramework.Companies;
using InventoryDesktop.EntityFramework.Distributors;
using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.ItemTypes;
using InventoryDesktop.EntityFramework.PurchaseItems;
using InventoryDesktop.EntityFramework.Purchases;
using InventoryDesktop.EntityFramework.Users;
using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionSettings.ConnectionString);
        }

    }
}
