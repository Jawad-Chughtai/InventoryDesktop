using InventoryDesktop.EntityFramework.Companies;
using InventoryDesktop.EntityFramework.Distributors;
using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.PurchaseItems;
using System.Formats.Asn1;

namespace InventoryDesktop.Applications.PurchaseItems
{
    public class PurchaseItemAppService
    {
        private readonly PurchaseItemRepository _purchaseItemRepository = new();
        private readonly ItemCategoryRepository _itemCategoryRepository = new();
        private readonly CompanyRepository _companyRepository = new();
        private readonly DistributorRepository _distributorRepository = new();

        public async Task CreateAsync(PurchaseItem purchaseItem)
        {
            var code = await CreateCodeAsync(purchaseItem);
            purchaseItem.Name = purchaseItem.Name.Trim();
            purchaseItem.Description = purchaseItem.Description?.Trim();
            purchaseItem.Code = code;

            await _purchaseItemRepository.CreateAsync(purchaseItem);
        }

        public async Task UpdateAsync(PurchaseItem purchaseItem)
        {
            var code = await CreateCodeAsync(purchaseItem);
            purchaseItem.Name = purchaseItem.Name.Trim();
            purchaseItem.Description = purchaseItem.Description?.Trim();
            purchaseItem.Code = code;

            await _purchaseItemRepository.UpdateAsync(purchaseItem);
        }

        public async Task<PurchaseItemDto> GetAsync(int id, bool includeDetails = false)
        {
            var purchaseItem = await _purchaseItemRepository.GetAsync(id, includeDetails);
            return await purchaseItem.ToPurchaseItemDto();
        }

        public async Task<List<PurchaseItemDto>> GetListAsync(string? searchText = null, bool includeDetails = false)
        {
            var purchaseItems = await _purchaseItemRepository.GetListAsync(searchText, includeDetails);
            return await purchaseItems.ToPurchaseItemDto();
        }

        public async Task DeleteAsync(int id)
        {
            await _purchaseItemRepository.DeleteAsync(id);
        }

        public async Task<List<ItemCategory>> GetItemCategoryLookupAsync()
        {
            return await _itemCategoryRepository.GetListAsync();
        }

        public async Task<List<Company>> GetCompanyLookupAsync()
        {
            return await _companyRepository.GetListAsync();
        }

        public async Task<List<Distributor>> GetDistributorLookupAsync()
        {
            return await _distributorRepository.GetListAsync();
        }

        private async Task<string> CreateCodeAsync(PurchaseItem purchaseItem)
        {
            var categoryCode = (await _itemCategoryRepository.GetAsync(purchaseItem.ItemCategoryId)).Code;
            var code = await _purchaseItemRepository.GetMaxCodeAsync(purchaseItem.ItemCategoryId);

            if (code == null)
            {
                return categoryCode + "-" + "00001";
            }
            else
            {
                return categoryCode + "-" + (Convert.ToInt32(code.Split('-')[1]) + 1).ToString("00000");
            }
        }
    }
}
