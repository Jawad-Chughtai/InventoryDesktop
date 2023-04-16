using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.ItemTypes;

namespace InventoryDesktop.Applications.ItemCategories
{
    public class ItemCategoryService : IItemCategoryService
    {
        private readonly IItemCategoryRepository _itemCategoryRepository;
        private readonly IItemTypeRepository _itemTypeRepository;

        public ItemCategoryService(
            IItemCategoryRepository itemCategoryRepository,
            IItemTypeRepository itemTypeRepository)
        {
            _itemCategoryRepository = itemCategoryRepository;
            _itemTypeRepository = itemTypeRepository;
        }

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
