using InventoryDesktop.EntityFramework.Companies;
using InventoryDesktop.EntityFramework.Distributors;
using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.PurchaseItems;

namespace InventoryDesktop.Applications.PurchaseItems
{
    public interface IPurchaseItemService
    {
        Task CreateAsync(PurchaseItem purchaseItem);
        Task DeleteAsync(int id);
        Task<PurchaseItemDto> GetAsync(int id, bool includeDetails = false);
        Task<List<Company>> GetCompanyLookupAsync();
        Task<List<Distributor>> GetDistributorLookupAsync();
        Task<List<ItemCategory>> GetItemCategoryLookupAsync();
        Task<List<PurchaseItemDto>> GetListAsync(string? searchText = null, bool includeDetails = false);
        Task UpdateAsync(PurchaseItem purchaseItem);
    }
}