using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework.ItemCategories
{
    public class ItemCategoryRepository
    {
        private readonly InventoryDbContext context = new();

        public async Task<ItemCategory> CreateAsync(ItemCategory category)
        {
            #region Existing Check

            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            if (await context.ItemCategories.AnyAsync(x => x.Name.ToLower() == category.Name.ToLower()))
            {
                throw new Exception($"Category with same name '{category.Name}' already exists");
            }
            else if (await context.ItemCategories.AnyAsync(x => x.Code.ToLower() == category.Code.ToLower()))
            {
                throw new Exception($"Category with same code '{category.Code}' already exists");
            }

            #endregion

            context.ItemCategories.Add(category);
            await context.SaveChangesAsync();
            return category;
        }

        public async Task<ItemCategory> UpdateAsync(ItemCategory category)
        {
            #region Existing Check

            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            if (await context.ItemCategories.AnyAsync(x => x.Name.ToLower() == category.Name.ToLower() && x.Id != category.Id))
            {
                throw new Exception($"Category with same name '{category.Name}' already exists");
            }
            else if (await context.ItemCategories.AnyAsync(x => x.Code.ToLower() == category.Code.ToLower() && x.Id != category.Id))
            {
                throw new Exception($"Category with same code '{category.Code}' already exists");
            }

            #endregion

            var entity = await context.ItemCategories.FirstOrDefaultAsync(x => x.Id == category.Id);
            if (entity != null)
            {
                entity.Name = category.Name;
                entity.Code = category.Code;
                entity.ItemTypeId = category.ItemTypeId;

                await context.SaveChangesAsync();
                return entity;
            }
            else
            {
                throw new Exception($"No record found with name: {category.Name}");
            }
        }

        public async Task<ItemCategory> GetAsync(int id)
        {
            return await context.ItemCategories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ItemCategory>> GetListAsync(
            string? searchText = null,
            int? typeId = null)
        {
            return await context.ItemCategories
                .Where(x => typeId == null || x.ItemTypeId == typeId)
                .Where(x => searchText == null
                || x.Name.ToLower().Contains(searchText)
                || x.Code.ToLower().Contains(searchText))
                .Include(x => x.ItemType)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.ItemCategories.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception($"No record found with id: {id}");
            context.ItemCategories.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<ItemCategory> FindByNameAsync(string name)
        {
            return await context.ItemCategories.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
