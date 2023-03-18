using InventoryDesktop.EntityFramework.Companies;
using InventoryDesktop.EntityFramework.Distributors;
using InventoryDesktop.EntityFramework.ItemCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDesktop.Applications.PurchaseItems
{
    public class PurchaseItemDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? DistributorId { get; set; }
        public string DistributorName { get; set; } 
        public int MinimumQuantity { get; set; }
    }
}
