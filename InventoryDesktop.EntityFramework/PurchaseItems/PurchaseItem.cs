using InventoryDesktop.EntityFramework.Companies;
using InventoryDesktop.EntityFramework.Distributors;
using InventoryDesktop.EntityFramework.ItemCategories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace InventoryDesktop.EntityFramework.PurchaseItems
{
    public class PurchaseItem
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        [AllowNull]
        public string? Description { get; set; }

        [Required]
        public int ItemCategoryId { get; set; }
        public int? CompanyId { get; set; }
        public int? DistributorId { get; set; }
        public int MinimumQuantity { get; set; } = 0;


        [ForeignKey(nameof(ItemCategoryId))]
        public ItemCategory? ItemCategory { get; set; }

        [ForeignKey(nameof(CompanyId))]
        public Company? Company { get; set; }

        [ForeignKey(nameof(DistributorId))]
        public Distributor? Distributor { get; set; } 
    }
}
