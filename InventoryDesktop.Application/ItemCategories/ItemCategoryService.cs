using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.ItemTypes;

namespace InventoryDesktop.Applications.ItemCategories
{
    public class ItemCategoryService
    {
        private readonly ItemCategoryRepository _itemCategoryRepository = new();
        private readonly ItemTypeRepository _itemTypeRepository = new();

        public async Task<ItemCategory> GetAsync(int id)
        {
            return await _itemCategoryRepository.GetAsync(id);
        }

        public async Task<List<ItemCategory>> GetListAsync(
            string? searchText = null,
            int? typeId = null)
        {
            searchText = searchText?.Trim().ToLower();

            return await _itemCategoryRepository.GetListAsync(searchText, typeId);
        }

        public async Task<ItemCategory> CreateAsync(ItemCategory category)
        {
            category.Name = category.Name.Trim();
            category.Code = category.Code.Trim().ToUpper();

            return await _itemCategoryRepository.CreateAsync(category);
        }

        public async Task<ItemCategory> UpdateAsync(ItemCategory category)
        {
            category.Name = category.Name.Trim();
            category.Code = category.Code.Trim().ToUpper();

            return await _itemCategoryRepository.UpdateAsync(category);
        }

        public async Task DeleteAsync(int id)
        {
            await _itemCategoryRepository.DeleteAsync(id);
        }

        public async Task<List<ItemType>> GetItemTypeLookup()
        {
            return await _itemTypeRepository.GetListAsync();
        }
    }
}
