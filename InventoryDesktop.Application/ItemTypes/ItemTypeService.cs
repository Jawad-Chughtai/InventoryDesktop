using InventoryDesktop.EntityFramework.ItemTypes;

namespace InventoryDesktop.Applications.ItemTypes
{
    public class ItemTypeService
    {
        private readonly ItemTypeRepository _itemTypeRepository = new();

        public async Task<ItemType> GetAsync(int id)
        {
            return await _itemTypeRepository.GetAsync(id);
        }

        public async Task<List<ItemType>> GetListAsync()
        {
            return await _itemTypeRepository.GetListAsync();
        }

        public async Task<ItemType> CreateAsync(ItemType category)
        {
            category.Name = category.Name.Trim();
            category.Code = category.Code.Trim().ToUpper();

            return await _itemTypeRepository.CreateAsync(category);
        }

        public async Task<ItemType> UpdateAsync(ItemType category)
        {
            category.Name = category.Name.Trim();
            category.Code = category.Code.Trim().ToUpper();

            return await _itemTypeRepository.UpdateAsync(category);
        }

        public async Task DeleteAsync(int id)
        {
            await _itemTypeRepository.DeleteAsync(id);
        }
    }
}
