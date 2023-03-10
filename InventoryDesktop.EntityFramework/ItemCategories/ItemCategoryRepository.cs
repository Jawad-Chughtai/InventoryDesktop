using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework.ItemCategories
{
    public class ItemCategoryRepository
    {
        private readonly InventoryDbContext _db = new();

        public async Task<ItemCategory> CreateAsync(ItemCategory subcategory)
        {
            if (subcategory == null)
            {
                throw new ArgumentNullException(nameof(subcategory));
            }
            _db.ItemCategories.Add(subcategory);
            await _db.SaveChangesAsync();
            return subcategory;
        }

        public async Task<ItemCategory> UpdateAsync(ItemCategory category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            var entity = await _db.ItemCategories.FirstOrDefaultAsync(x => x.Id == category.Id);
            if(entity != null)
            {
                entity.Name = category.Name;
                entity.ItemTypeId = category.ItemTypeId;
                await _db.SaveChangesAsync();
                return entity;
            }
            else
            {
                throw new Exception($"No record found with name: {category.Name}");
            }
        }

        public async Task<ItemCategory> GetAsync(int id)
        {
            return await _db.ItemCategories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ItemCategory>> GetListAsync()
        {
            var x = await _db.ItemCategories
                .Include(x => x.ItemType)
                .OrderBy(x => x.Name)
                .ToListAsync();
            return x;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _db.ItemCategories.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception($"No record found with id: {id}");
            _db.ItemCategories.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<ItemCategory> FindByNameAsync(string name)
        {
            return await _db.ItemCategories.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
