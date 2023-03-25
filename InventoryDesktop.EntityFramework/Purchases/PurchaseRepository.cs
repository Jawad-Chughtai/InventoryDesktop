using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework.Purchases
{
    public class PurchaseRepository
    {
        private readonly InventoryDbContext context = new();

        public async Task CreateAsync(Purchase purchase)
        {
            if (purchase == null)
            {
                throw new ArgumentNullException(nameof(purchase));
            }

            context.Purchases.Add(purchase);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Purchase purchase)
        {
            if (purchase == null)
            {
                throw new ArgumentNullException(nameof(purchase));
            }
            var entity = await context.Purchases.FirstOrDefaultAsync(x => x.Id == purchase.Id)
                ?? throw new Exception($"Purchase with Id: '{purchase.Id}' not found");

            context.Purchases.Remove(purchase);
            context.Purchases.Add(purchase);
            await context.SaveChangesAsync();
        }

        public async Task<Purchase> GetAsync(int id)
        {
            return await context.Purchases.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Purchase> GetAsync(string barcode)
        {
            return await context.Purchases.FirstOrDefaultAsync(x => x.Barcode == barcode);
        }

        public async Task<List<Purchase>> GetListAsync(string? filter = null, int? purchaseItemId = null)
        {
            var query = await context.Purchases.AsQueryable()
                            .Where(x => filter == null
                            || x.PurchaseItemDescription.Contains(filter)
                            || x.Batch.Contains(filter)
                            || x.Barcode.Contains(filter))
                            .Where(x => purchaseItemId == null || x.PurchaseItemId == purchaseItemId)
                            .OrderByDescending(x => x.CreationTime)
                            .ToListAsync();
            return query;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.Purchases.FirstOrDefaultAsync(x => x.Id == id) 
                ?? throw new Exception($"Purchase with Id: '{id}' not found.");
            context.Purchases.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string barcode)
        {
            var entity = await context.Purchases.FirstOrDefaultAsync(x => x.Barcode == barcode) 
                ?? throw new Exception($"Purchase with Barcode: '{barcode}' not found.");
            context.Purchases.Remove(entity);
            await context.SaveChangesAsync();
        }
    }
}
