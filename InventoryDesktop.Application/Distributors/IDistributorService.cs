using InventoryDesktop.EntityFramework.Distributors;

namespace InventoryDesktop.Applications.Distributors
{
    public interface IDistributorService
    {
        Task CreateAsync(Distributor distributor);
        Task DeleteAsync(int id);
        Task<Distributor> GetAsync(int id);
        Task<List<Distributor>> GetListAsync();
    }
}