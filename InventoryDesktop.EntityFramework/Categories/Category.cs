using InventoryDesktop.EntityFramework.SubCategories;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InventoryDesktop.EntityFramework.Categories
{
    [Index(nameof(Name))]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
