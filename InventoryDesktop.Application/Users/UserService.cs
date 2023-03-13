using InventoryDesktop.EntityFramework.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDesktop.Applications.Users
{
    public class UserService
    {
        private readonly UserRepository _userRepository = new();
        public async Task<int> LoginAsync(string? username, string? password)
        {
            return await _userRepository.LoginAsync(username, password);    
        }
    }
}
