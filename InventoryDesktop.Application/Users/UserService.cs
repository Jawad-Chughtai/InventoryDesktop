using InventoryDesktop.EntityFramework.Users;

namespace InventoryDesktop.Applications.Users
{
    public class UserService
    {
        private readonly UserRepository _userRepository = new();
        public async Task<User> LoginAsync(string? username, string? password)
        {
            return await _userRepository.LoginAsync(username, password);
        }

        public async Task<User> GetAsync(int id)
        {
            return await _userRepository.GetAsync(id);
        }

        public async Task<User> CreateAsync(User user)
        {
            user.FirstName = user.FirstName.Trim();
            user.LastName = user.LastName?.Trim();
            user.IsIncluded = true;
            user.CreationTime = DateTime.Now;

            return await _userRepository.CreateAsync(user);
        }

        public async Task<User> UpdateAsync(User user)
        {
            user.FirstName = user.FirstName.Trim();
            user.LastName = user.LastName?.Trim();
            user.IsIncluded = true;

            return await _userRepository.UpdateAsync(user);
        }

        public async Task<List<User>> GetListAsync()
        {
            return await _userRepository.GetListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<User> GetSuperAdminAsync(string role)
        {
            return await _userRepository.GetSuperAdminAsync(role);
        }
    }
}
