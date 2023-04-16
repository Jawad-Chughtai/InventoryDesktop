namespace InventoryDesktop.EntityFramework.ItemTypes
{
    public interface IItemTypeRepository
    {
        Task<ItemType> CreateAsync(ItemType itemType);
        Task DeleteAsync(int id);
        Task<ItemType> FindByNameAsync(string name);
        Task<ItemType> GetAsync(int id);
        Task<List<ItemType>> GetListAsync(string? searchText = null);
        Task<ItemType> UpdateAsync(ItemType itemType);
    }
}