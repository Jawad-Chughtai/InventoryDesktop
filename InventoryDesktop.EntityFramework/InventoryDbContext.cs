using InventoryDesktop.EntityFramework.Categories;
using InventoryDesktop.EntityFramework.SubCategories;
using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Initial Catalog=InventoryDesktop;Integrated Security=True;MultipleActiveResultSets=true;Trusted_Connection=true;TrustServerCertificate=True");
        }
    }
}
