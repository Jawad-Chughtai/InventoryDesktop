using InventoryDesktop.EntityFramework.ItemTypes;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDesktop.EntityFramework.ItemCategories
{
    [Index(nameof(Name))]
    public class ItemCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Code { get; set; }

        [Required]
        public int ItemTypeId { get; set; }

        [ForeignKey(nameof(ItemTypeId))]
        public ItemType ItemType { get; set; }
    }
}
