namespace InventoryDesktop.EntityFramework.Users
{
    public interface IUserRepository
    {
        Task<User> CreateAsync(User user);
        Task DeleteAsync(int id);
        Task<User> GetAsync(int id);
        Task<List<User>> GetListAsync();
        Task<User> GetSuperAdminAsync(string role);
        Task<User> LoginAsync(string? username, string? password);
        Task<User> UpdateAsync(User user);
    }
}