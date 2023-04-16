using InventoryDesktop.EntityFramework.Companies;

namespace InventoryDesktop.Applications.Companies
{
    public interface ICompanyService
    {
        Task CreateAsync(Company company);
        Task DeleteAsync(int id);
        Task<Company> GetAsync(int id);
        Task<List<Company>> GetListAsync();
    }
}