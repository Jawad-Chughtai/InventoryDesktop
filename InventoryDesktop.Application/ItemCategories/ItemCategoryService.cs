using InventoryDesktop.EntityFramework.ItemTypes;
using InventoryDesktop.EntityFramework.ItemCategories;

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

        public async Task<List<ItemCategory>> GetListAsync()
        {
            return await _itemCategoryRepository.GetListAsync();
        }

        public async Task<ItemCategory> CreateAsync(ItemCategory subcategory)
        {
            subcategory.Name = subcategory.Name.Trim();
            var existing = await _itemCategoryRepository.FindByNameAsync(subcategory.Name);
            if (existing != null)
            {
                throw new Exception($"Sub Category with same name '{subcategory.Name}' already exists.");
            }
            return await _itemCategoryRepository.CreateAsync(subcategory);
        }

        public async Task<ItemCategory> UpdateAsync(ItemCategory subcategory)
        {
            subcategory.Name = subcategory.Name.Trim();
            var existing = await _itemCategoryRepository.FindByNameAsync(subcategory.Name);
            if (existing != null && existing.Id != subcategory.Id)
            {
                throw new Exception($"Sub Category with same name '{subcategory.Name}' already exists.");
            }
            return await _itemCategoryRepository.UpdateAsync(subcategory);
        }

        public async Task DeleteAsync(int id)
        {
            await _itemCategoryRepository.DeleteAsync(id);
        }

        public async Task<List<ItemType>> GetCategoryLookupAsync()
        {
            return await _itemTypeRepository.GetListAsync();
        }
    }
}
