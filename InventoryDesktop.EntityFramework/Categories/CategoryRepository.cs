using InventoryDesktop.EntityFramework.SubCategories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDesktop.EntityFramework.Categories
{
    public class CategoryRepository
    {
        private readonly InventoryDbContext _db = new();

        public async Task<Category> CreateAsync(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }
            _db.Categories.Add(category);
            await _db.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            var entity = await _db.Categories.FirstOrDefaultAsync(x => x.Id == category.Id);
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

        public async Task<Category> GetAsync(int id)
        {
            return await _db.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Category>> GetListAsync()
        {
            return await _db.Categories.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentNullException(nameof(id));
            var any = await _db.SubCategories.AnyAsync(x => x.CategoryId == id);
            if(!any)
            {
                _db.Categories.Remove(entity);
                await _db.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"Cannot delete {entity.Name} - Data used in sub category.");
            }
        }

        public async Task<Category> FindByNameAsync(string name)
        {
            return await _db.Categories.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
