using InventoryDesktop.EntityFramework.Distributors;

namespace InventoryDesktop.Applications.Distributors
{
    public class DistributorAppService
    {
        private readonly DistributorRepository _distributorRepository = new();

        public async Task CreateAsync(Distributor distributor)
        {
            distributor.Name = distributor.Name.Trim();
            distributor.Contact = distributor.Contact.Trim();

            await _distributorRepository.CreateAsync(distributor);
        }

        public async Task DeleteAsync(int id)
        {
            await _distributorRepository.DeleteAsync(id);
        }

        public async Task<Distributor> GetAsync(int id)
        {
            return await _distributorRepository.GetAsync(id);
        }

        public async Task<List<Distributor>> GetListAsync()
        {
            return await _distributorRepository.GetListAsync();
        }
    }
}
