using InventoryDesktop.EntityFramework.ItemTypes;

namespace InventoryDesktop.Applications.ItemTypes
{
    public interface IItemTypeService
    {
        Task<ItemType> CreateAsync(ItemType itemType);
        Task DeleteAsync(int id);
        Task<ItemType> GetAsync(int id);
        Task<List<ItemType>> GetListAsync(string? searchText = null);
        Task<ItemType> UpdateAsync(ItemType itemType);
    }
}