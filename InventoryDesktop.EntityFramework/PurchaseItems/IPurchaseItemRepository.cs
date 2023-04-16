namespace InventoryDesktop.EntityFramework.PurchaseItems
{
    public interface IPurchaseItemRepository
    {
        Task CreateAsync(PurchaseItem purchaseItem);
        Task DeleteAsync(int id);
        Task<PurchaseItem> GetAsync(int id, bool includeDetails = false);
        Task<List<PurchaseItem>> GetListAsync(string? searchText = null, bool includeDetails = false);
        Task<string> GetMaxCodeAsync(int categoryId);
        Task UpdateAsync(PurchaseItem purchaseItem);
    }
}