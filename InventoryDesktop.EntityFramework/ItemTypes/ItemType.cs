using InventoryDesktop.EntityFramework.ItemCategories;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InventoryDesktop.EntityFramework.ItemTypes
{
    [Index(nameof(Name))]
    public class ItemType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
