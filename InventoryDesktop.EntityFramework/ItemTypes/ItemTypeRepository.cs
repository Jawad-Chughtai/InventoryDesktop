using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework.ItemTypes
{
    public class ItemTypeRepository
    {
        private readonly InventoryDbContext _db = new();

        public async Task<ItemType> CreateAsync(ItemType category)
        {
            #region Existing Check

            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            if(await _db.ItemTypes.AnyAsync(x => x.Name.ToLower() == category.Name.ToLower()))
            {
                throw new Exception($"Category with same name '{category.Name}' already exists.");
            }
            else if(await _db.ItemTypes.AnyAsync(x => x.Code.ToLower() == category.Code.ToLower()))
            {
                throw new Exception($"Category with same code '{category.Code}' already exists.");
            }

            #endregion

            _db.ItemTypes.Add(category);
            await _db.SaveChangesAsync();
            return category;
        }

        public async Task<ItemType> UpdateAsync(ItemType category)
        {
            #region Existing Check

            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            if (await _db.ItemTypes.AnyAsync(x => x.Name.ToLower() == category.Name.ToLower()))
            {
                throw new Exception($"Category with same name '{category.Name}' already exists.");
            }
            else if (await _db.ItemTypes.AnyAsync(x => x.Code.ToLower() == category.Code.ToLower()))
            {
                throw new Exception($"Category with same code '{category.Code}' already exists.");
            }

            #endregion

            var entity = await _db.ItemTypes.FirstOrDefaultAsync(x => x.Id == category.Id);
            if (entity != null)
            {
                entity.Name = category.Name;
                await _db.SaveChangesAsync();
                return category;
            }
            else
            {
                throw new Exception($"No record found with name: {category.Name}");
            }
        }

        public async Task<ItemType> GetAsync(int id)
        {
            return await _db.ItemTypes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ItemType>> GetListAsync()
        {
            return await _db.ItemTypes.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _db.ItemTypes.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentNullException(nameof(id));
            var any = await _db.ItemCategories.AnyAsync(x => x.ItemTypeId == id);
            if(!any)
            {
                _db.ItemTypes.Remove(entity);
                await _db.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"Cannot delete {entity.Name} - Data used in sub category.");
            }
        }

        public async Task<ItemType> FindByNameAsync(string name)
        {
            return await _db.ItemTypes.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
