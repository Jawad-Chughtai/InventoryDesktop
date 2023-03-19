using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework.Companies
{
    public class CompanyRepository
    {
        private readonly InventoryDbContext context = new();

        public async Task CreateAsync(Company company)
        {
            if (company == null)
            {
                throw new ArgumentNullException(nameof(company));
            }

            if (await context.Companies.AnyAsync(x => x.Name.ToLower() == company.Name.ToLower()))
            {
                throw new Exception($"Company with same name '{company.Name}' already exists");
            }

            context.Companies.Add(company);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            if (! await context.PurchaseItems.AnyAsync(x => x.CompanyId == id))
            {
                var any = await context.Companies.FirstOrDefaultAsync(x => x.Id == id)
                        ?? throw new Exception($"Company with id '{id}' not found");
                context.Companies.Remove(any);
                await context.SaveChangesAsync(); 
            }
            else
            {
                throw new Exception("Can not delete Company - Record exists in Purchase Items");
            }
        }

        public async Task<Company> GetAsync(int id)
        {
            var any = await context.Companies.FirstOrDefaultAsync(x => x.Id == id)
                ?? throw new Exception($"Company with id '{id}' not found");
            return any;
        }

        public async Task<List<Company>> GetListAsync()
        {
            return await context.Companies.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
