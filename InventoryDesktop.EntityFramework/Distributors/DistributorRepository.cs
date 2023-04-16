using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework.Distributors
{
    public class DistributorRepository : IDistributorRepository
    {
        private readonly InventoryDbContext context;
        
        public DistributorRepository(
            InventoryDbContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(Distributor distributor)
        {
            if (distributor == null)
            {
                throw new ArgumentNullException(nameof(distributor));
            }

            if (await context.Distributors.AnyAsync(x => x.Name.ToLower() == distributor.Name.ToLower()))
            {
                throw new Exception($"Distributor with same name '{distributor.Name}' already exists");
            }

            context.Distributors.Add(distributor);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            if (!await context.PurchaseItems.AnyAsync(x => x.DistributorId == id))
            {
                var any = await context.Distributors.FirstOrDefaultAsync(x => x.Id == id)
                        ?? throw new Exception($"Distributor with id '{id}' not found");
                context.Distributors.Remove(any);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Can not delete Distributor - Record exists in Purchase Items");
            }
        }

        public async Task<Distributor> GetAsync(int id)
        {
            var any = await context.Distributors.FirstOrDefaultAsync(x => x.Id == id)
                ?? throw new Exception($"Distributor with id '{id}' not found");
            return any;
        }

        public async Task<List<Distributor>> GetListAsync()
        {
            return await context.Distributors.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
