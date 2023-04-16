using InventoryDesktop.EntityFramework.Users;
using System.Security.Cryptography;
using System.Text;

namespace InventoryDesktop.Applications.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> LoginAsync(string? username, string? password)
        {
            password = HashPassword(password);
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
            user.Password = HashPassword(user.Password);

            return await _userRepository.CreateAsync(user);
        }

        public async Task<User> UpdateAsync(User user)
        {
            user.FirstName = user.FirstName.Trim();
            user.LastName = user.LastName?.Trim();
            user.IsIncluded = true;
            user.Password = HashPassword(user.Password);

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

        public static string HashPassword(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = SHA256.HashData(passwordBytes);

            return Convert.ToBase64String(hashBytes);
        }
    }
}
