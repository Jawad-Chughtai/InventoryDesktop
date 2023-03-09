using InventoryDesktop.EntityFramework.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDesktop.Applications.Categories
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository = new();

        public async Task<Category> GetAsync(int id)
        {
            return await _categoryRepository.GetAsync(id);
        }

        public async Task<List<Category>> GetListAsync()
        {
            return await _categoryRepository.GetListAsync();
        }

        public async Task<Category> CreateAsync(Category category)
        {
            category.Name = category.Name.Trim();   
            var existing = await _categoryRepository.FindByNameAsync(category.Name);
            if (existing != null)
            {
                throw new Exception($"Category with same name '{category.Name}' already exists.");
            }
            return await _categoryRepository.CreateAsync(category);
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            category.Name = category.Name.Trim();
            var existing = await _categoryRepository.FindByNameAsync(category.Name);
            if(existing != null && existing.Id != category.Id)
            {
                throw new Exception($"Category with same name '{category.Name}' already exists.");
            }
            return await _categoryRepository.UpdateAsync(category);
        }

        public async Task DeleteAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }
    }
}
