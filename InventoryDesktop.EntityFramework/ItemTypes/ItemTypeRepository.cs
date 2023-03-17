using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework.ItemTypes
{
    public class ItemTypeRepository
    {
        private readonly InventoryDbContext context = new();

        public async Task<ItemType> CreateAsync(ItemType itemType)
        {
            #region Existing Check

            if (itemType == null)
            {
                throw new ArgumentNullException(nameof(itemType));
            }

            if (await context.ItemTypes.AnyAsync(x => x.Name.ToLower() == itemType.Name.ToLower()))
            {
                throw new Exception($"Category with same name '{itemType.Name}' already exists.");
            }
            else if (await context.ItemTypes.AnyAsync(x => x.Code.ToLower() == itemType.Code.ToLower()))
            {
                throw new Exception($"Category with same code '{itemType.Code}' already exists.");
            }

            #endregion

            context.ItemTypes.Add(itemType);
            await context.SaveChangesAsync();
            return itemType;
        }

        public async Task<ItemType> UpdateAsync(ItemType itemType)
        {
            #region Existing Check

            if (itemType == null)
            {
                throw new ArgumentNullException(nameof(itemType));
            }

            if (await context.ItemTypes.AnyAsync(x => x.Name.ToLower() == itemType.Name.ToLower() && x.Id != itemType.Id))
            {
                throw new Exception($"Item type with same name '{itemType.Name}' already exists.");
            }
            else if (await context.ItemTypes.AnyAsync(x => x.Code.ToLower() == itemType.Code.ToLower() && x.Id != itemType.Id))
            {
                throw new Exception($"Item type with same code '{itemType.Code}' already exists.");
            }

            #endregion

            var entity = await context.ItemTypes.FirstOrDefaultAsync(x => x.Id == itemType.Id);
            if (entity != null)
            {
                entity.Name = itemType.Name;
                await context.SaveChangesAsync();
                return itemType;
            }
            else
            {
                throw new Exception($"No record found with name: {itemType.Name}");
            }
        }

        public async Task<ItemType> GetAsync(int id)
        {
            return await context.ItemTypes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ItemType>> GetListAsync(string? searchText = null)
        {
            return await context.ItemTypes
                    .Where(x => searchText == null
                    || x.Name.ToLower().Contains(searchText)
                    || x.Code.ToLower().Contains(searchText))
                    .OrderBy(x => x.Name)
                    .ToListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.ItemTypes.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentNullException(nameof(id));
            var any = await context.ItemCategories.AnyAsync(x => x.ItemTypeId == id);
            if (!any)
            {
                context.ItemTypes.Remove(entity);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"Cannot delete {entity.Name} - Data used in sub category.");
            }
        }

        public async Task<ItemType> FindByNameAsync(string name)
        {
            return await context.ItemTypes.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
