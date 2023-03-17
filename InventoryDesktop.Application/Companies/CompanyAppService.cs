using InventoryDesktop.EntityFramework.Companies;

namespace InventoryDesktop.Applications.Companies
{
    public class CompanyAppService
    {
        private readonly CompanyRepository _companyRepository = new();

        public async Task CreateAsync(Company company)
        {
            company.Name = company.Name.Trim();
            await _companyRepository.CreateAsync(company);
        }

        public async Task DeleteAsync(int id)
        {
            await _companyRepository.DeleteAsync(id);
        }

        public async Task<Company> GetAsync(int id)
        {
            return await _companyRepository.GetAsync(id);
        }

        public async Task<List<Company>> GetListAsync()
        {
            return await _companyRepository.GetListAsync();
        }
    }
}
