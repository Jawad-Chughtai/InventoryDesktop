using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.ItemTypes;
using InventoryDesktop.EntityFramework.Users;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace InventoryDesktop.EntityFramework
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionSettings.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure your entity models here

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Super",
                    LastName = "Admin",
                    Username = "superadmin",
                    Password = "Admin123?",
                    IsDeleted = false,
                    IsIncluded = false,
                    Role = "SuperAdmin"
                }
            );

            modelBuilder.Entity<ItemType>().HasData(
                new ItemType
                {
                    Id = 1,
                    Name = "Other",
                    Code = "O"
                });

            modelBuilder.Entity<ItemCategory>().HasData(
                new ItemCategory
                {
                    Id = 1,
                    Name = "Other",
                    Code = "O",
                    ItemTypeId = 1
                });
        }
    }
}
