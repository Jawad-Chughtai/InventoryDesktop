using InventoryDesktop.EntityFramework.ItemTypes;

namespace InventoryDesktop.Applications.ItemTypes
{
    public class ItemTypeService : IItemTypeService
    {
        private readonly IItemTypeRepository _itemTypeRepository;
        public ItemTypeService(IItemTypeRepository itemTypeRepository)
        {
            _itemTypeRepository = itemTypeRepository;
        }
        public async Task<ItemType> GetAsync(int id)
        {
            return await _itemTypeRepository.GetAsync(id);
        }

        public async Task<List<ItemType>> GetListAsync(string? searchText = null)
        {
            searchText = searchText?.Trim().ToLower();
            return await _itemTypeRepository.GetListAsync(searchText);
        }

        public async Task<ItemType> CreateAsync(ItemType itemType)
        {
            itemType.Name = itemType.Name.Trim();
            itemType.Code = itemType.Code.Trim().ToUpper();

            return await _itemTypeRepository.CreateAsync(itemType);
        }

        public async Task<ItemType> UpdateAsync(ItemType itemType)
        {
            itemType.Name = itemType.Name.Trim();
            itemType.Code = itemType.Code.Trim().ToUpper();

            return await _itemTypeRepository.UpdateAsync(itemType);
        }

        public async Task DeleteAsync(int id)
        {
            await _itemTypeRepository.DeleteAsync(id);
        }
    }
}
