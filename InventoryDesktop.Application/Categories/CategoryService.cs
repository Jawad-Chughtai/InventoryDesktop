using InventoryDesktop.EntityFramework.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDesktop.Applications.Categories
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository = new();

        public async Task<Category> CreateAsync(Category category)
        {
            return await _categoryRepository.CreateAsync(category);
        }

        public async Task<Category> UpdateAsync(int id, Category category)
        {
            category.Id = id;
            return await _categoryRepository.UpdateAsync(category);
        }

        public async Task<Category> GetAsync(int id)
        {
            return await _categoryRepository.GetAsync(id);
        }

        public async Task<List<Category>> GetListAsync()
        {
            return await _categoryRepository.GetListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);  
        }
    }
}
