using InventoryDesktop.EntityFramework.Companies;

namespace InventoryDesktop.Applications.Companies
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

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
