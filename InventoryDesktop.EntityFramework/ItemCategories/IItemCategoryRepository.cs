namespace InventoryDesktop.EntityFramework.ItemCategories
{
    public interface IItemCategoryRepository
    {
        Task<ItemCategory> CreateAsync(ItemCategory category);
        Task DeleteAsync(int id);
        Task<ItemCategory> FindByNameAsync(string name);
        Task<ItemCategory> GetAsync(int id);
        Task<List<ItemCategory>> GetListAsync(string? searchText = null, int? typeId = null);
        Task<ItemCategory> UpdateAsync(ItemCategory category);
    }
}