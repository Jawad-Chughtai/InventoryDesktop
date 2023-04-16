using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.ItemTypes;

namespace InventoryDesktop.Applications.ItemCategories
{
    public interface IItemCategoryService
    {
        Task<ItemCategory> CreateAsync(ItemCategory category);
        Task DeleteAsync(int id);
        Task<ItemCategory> GetAsync(int id);
        Task<List<ItemType>> GetItemTypeLookup();
        Task<List<ItemCategory>> GetListAsync(string? searchText = null, int? typeId = null);
        Task<ItemCategory> UpdateAsync(ItemCategory category);
    }
}