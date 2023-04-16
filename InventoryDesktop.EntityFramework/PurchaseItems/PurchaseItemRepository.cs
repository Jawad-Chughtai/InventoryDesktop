using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework.PurchaseItems
{
    public class PurchaseItemRepository : IPurchaseItemRepository
    {
        private readonly InventoryDbContext context;
        public PurchaseItemRepository(InventoryDbContext context)
        {
            this.context = context;
        }
        public async Task CreateAsync(PurchaseItem purchaseItem)
        {
            if (purchaseItem == null)
            {
                throw new ArgumentNullException(nameof(purchaseItem));
            }

            if (await context.PurchaseItems.AnyAsync(x => x.Name.ToLower() == purchaseItem.Name.ToLower()))
            {
                throw new Exception($"Purchase item with same name '{purchaseItem.Name}' already exists");
            }

            context.PurchaseItems.Add(purchaseItem);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PurchaseItem purchaseItem)
        {
            if (purchaseItem == null)
            {
                throw new ArgumentNullException(nameof(purchaseItem));
            }

            var entity = await context.PurchaseItems.FirstOrDefaultAsync(x => x.Id == purchaseItem.Id) ?? throw new Exception($"Purchase item with id '{purchaseItem.Id}' not found");
            if (entity?.Id != purchaseItem.Id && entity?.Name.ToLower() == purchaseItem.Name.ToLower())
            {
                throw new Exception($"Purchase item with same name '{purchaseItem.Name}' already exists");
            }

            entity.Name = purchaseItem.Name;
            entity.Code = purchaseItem.Code;
            entity.Description = purchaseItem.Description;
            entity.ItemCategoryId = purchaseItem.ItemCategoryId;
            entity.MinimumQuantity = purchaseItem.MinimumQuantity;
            entity.DistributorId = purchaseItem.DistributorId;
            entity.CompanyId = purchaseItem.CompanyId;

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.PurchaseItems
                                .FirstOrDefaultAsync(x => x.Id == id)
                                ?? throw new Exception($"Purchase item with id '{id}' not found");

            context.PurchaseItems.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<PurchaseItem> GetAsync(int id, bool includeDetails = false)
        {
            if (includeDetails)
            {
                return await context.PurchaseItems
                                .Include(x => x.ItemCategory)
                                .ThenInclude(c => c.ItemType)
                                .Include(x => x.Distributor)
                                .Include(x => x.Company)
                                .FirstOrDefaultAsync(x => x.Id == id)
                                ?? throw new Exception($"Purchase item with id '{id}' not found");
            }
            else
            {
                return await context.PurchaseItems
                                .FirstOrDefaultAsync(x => x.Id == id)
                                ?? throw new Exception($"Purchase item with id '{id}' not found");
            }
        }

        public async Task<List<PurchaseItem>> GetListAsync(string? searchText = null, bool includeDetails = false)
        {
            if (includeDetails)
            {
                return await context.PurchaseItems
                                .Where(x => searchText == null
                                || x.Name.Contains(searchText)
                                || x.Code.Contains(searchText))
                                .Include(x => x.ItemCategory)
                                .ThenInclude(c => c.ItemType)
                                .Include(x => x.Distributor)
                                .Include(x => x.Company)
                                .OrderBy(x => x.Name)
                                .ToListAsync();
            }
            else
            {
                return await context.PurchaseItems
                                .Where(x => searchText == null
                                || x.Name.Contains(searchText)
                                || x.Code.Contains(searchText))
                                .OrderBy(x => x.Name)
                                .ToListAsync();
            }
        }

        public async Task<string> GetMaxCodeAsync(int categoryId)
        {
            var item = await context.PurchaseItems.Where(x => x.ItemCategoryId == categoryId).MaxAsync(x => x.Code);
            return item;
        }
    }
}
