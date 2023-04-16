namespace InventoryDesktop.EntityFramework.Distributors
{
    public interface IDistributorRepository
    {
        Task CreateAsync(Distributor distributor);
        Task DeleteAsync(int id);
        Task<Distributor> GetAsync(int id);
        Task<List<Distributor>> GetListAsync();
    }
}