namespace InventoryDesktop.EntityFramework.Companies
{
    public interface ICompanyRepository
    {
        Task CreateAsync(Company company);
        Task DeleteAsync(int id);
        Task<Company> GetAsync(int id);
        Task<List<Company>> GetListAsync();
    }
}