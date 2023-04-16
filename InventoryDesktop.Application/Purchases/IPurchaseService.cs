using InventoryDesktop.Applications.PurchaseItems;
using InventoryDesktop.EntityFramework.Purchases;

namespace InventoryDesktop.Applications.Purchases
{
    public interface IPurchaseService
    {
        Task CreateAsync(Purchase purchase);
        Task<List<Purchase>> GetListAsync(string? filter = null, int? purchaseItemId = null);
        Task<List<PurchaseItemLookupDto>> GetPurchaseItemLookupAsync();
    }
}