using InventoryDesktop.EntityFramework.Categories;
using InventoryDesktop.EntityFramework.SubCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDesktop.Applications.SubCategories
{
    public class SubCategoryService
    {
        private readonly SubCategoryRepository _subCategoryRepository = new();
        private readonly CategoryRepository _categoryRepository = new();

        public async Task<SubCategory> GetAsync(int id)
        {
            return await _subCategoryRepository.GetAsync(id);
        }

        public async Task<List<SubCategory>> GetListAsync()
        {
            return await _subCategoryRepository.GetListAsync();
        }

        public async Task<SubCategory> CreateAsync(SubCategory subcategory)
        {
            subcategory.Name = subcategory.Name.Trim();
            var existing = await _subCategoryRepository.FindByNameAsync(subcategory.Name);
            if (existing != null)
            {
                throw new Exception($"Sub Category with same name '{subcategory.Name}' already exists.");
            }
            return await _subCategoryRepository.CreateAsync(subcategory);
        }

        public async Task<SubCategory> UpdateAsync(SubCategory subcategory)
        {
            subcategory.Name = subcategory.Name.Trim();
            var existing = await _subCategoryRepository.FindByNameAsync(subcategory.Name);
            if (existing != null && existing.Id != subcategory.Id)
            {
                throw new Exception($"Sub Category with same name '{subcategory.Name}' already exists.");
            }
            return await _subCategoryRepository.UpdateAsync(subcategory);
        }

        public async Task DeleteAsync(int id)
        {
            await _subCategoryRepository.DeleteAsync(id);
        }

        public async Task<List<Category>> GetCategoryLookupAsync()
        {
            return await _categoryRepository.GetListAsync();
        }
    }
}
