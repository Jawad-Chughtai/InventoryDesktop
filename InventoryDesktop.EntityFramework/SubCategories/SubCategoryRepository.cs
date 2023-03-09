using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework.SubCategories
{
    public class SubCategoryRepository
    {
        private readonly InventoryDbContext _db = new();

        public async Task<SubCategory> CreateAsync(SubCategory subcategory)
        {
            if (subcategory == null)
            {
                throw new ArgumentNullException(nameof(subcategory));
            }
            _db.SubCategories.Add(subcategory);
            await _db.SaveChangesAsync();
            return subcategory;
        }

        public async Task<SubCategory> UpdateAsync(SubCategory subcategory)
        {
            if (subcategory == null)
            {
                throw new ArgumentNullException(nameof(subcategory));
            }
            var entity = await _db.SubCategories.FirstOrDefaultAsync(x => x.Id == subcategory.Id);
            if(entity != null)
            {
                entity.Name = subcategory.Name;
                entity.CategoryId = subcategory.CategoryId;
                await _db.SaveChangesAsync();
                return entity;
            }
            else
            {
                throw new Exception($"No record found with name: {subcategory.Name}");
            }
        }

        public async Task<SubCategory> GetAsync(int id)
        {
            return await _db.SubCategories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<SubCategory>> GetListAsync()
        {
            return await _db.SubCategories
                .Include(x => x.Category)
                .OrderBy(x => x.Name)
                .ToListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _db.SubCategories.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception($"No record found with id: {id}");
            _db.SubCategories.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<SubCategory> FindByNameAsync(string name)
        {
            return await _db.SubCategories.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
