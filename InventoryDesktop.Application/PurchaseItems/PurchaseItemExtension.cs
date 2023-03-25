using InventoryDesktop.EntityFramework.PurchaseItems;

namespace InventoryDesktop.Applications.PurchaseItems
{
    public static class PurchaseItemExtension
    {
        public static Task<PurchaseItemDto> ToPurchaseItemDto(this PurchaseItem item)
        {
            var dto = new PurchaseItemDto
            {
                Id = item.Id,
                Code = item.Code,
                Name = item.Name,
                Description = item.Description,
                MinimumQuantity = item.MinimumQuantity,
                ItemCategoryName = item.ItemCategory?.Name,
                CompanyId = item.CompanyId,
                CompanyName = item.Company?.Name,
                DistributorId = item.DistributorId,
                DistributorName = item.Distributor?.Name
            };

            return Task.FromResult(dto);
        }

        public static Task<List<PurchaseItemDto>> ToPurchaseItemDto(this List<PurchaseItem> items)
        {
            var dtos = new List<PurchaseItemDto>();
            foreach (var item in items)
            {
                dtos.Add(new PurchaseItemDto
                {
                    Id = item.Id,
                    Code = item.Code,
                    Name = item.Name,
                    Description = item.Description,
                    MinimumQuantity = item.MinimumQuantity,
                    ItemCategoryId = item.ItemCategoryId,
                    ItemCategoryName = item.ItemCategory?.Name,
                    CompanyId = item.CompanyId,
                    CompanyName = item.Company?.Name,
                    DistributorId = item.DistributorId,
                    DistributorName = item.Distributor?.Name
                });
            }

            return Task.FromResult(dtos);
        }

        public static Task<List<PurchaseItemLookupDto>> ToPurchaseItemLookupDto(this List<PurchaseItem> items)
        {
            var dtos = new List<PurchaseItemLookupDto>();
            foreach(var item in items)
            {
                dtos.Add(new PurchaseItemLookupDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Code = item.Code
                });
            }

            return Task.FromResult(dtos);
        }
    }
}
