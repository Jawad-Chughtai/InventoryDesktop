namespace InventoryDesktop.EntityFramework.Purchases
{
    public interface IPurchaseRepository
    {
        Task CreateAsync(Purchase purchase);
        Task DeleteAsync(int id);
        Task DeleteAsync(string barcode);
        Task<Purchase> GetAsync(int id);
        Task<Purchase> GetAsync(string barcode);
        Task<List<Purchase>> GetListAsync(string? filter = null, int? purchaseItemId = null);
        Task UpdateAsync(Purchase purchase);
    }
}