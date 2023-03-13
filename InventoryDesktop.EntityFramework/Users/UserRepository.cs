using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDesktop.EntityFramework.Users
{
    public class UserRepository
    {
        private readonly InventoryDbContext _db = new();

        public async Task CreateAsync(User user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            else if(await _db.Users.AnyAsync(x => x.Username.ToLower() == user.Username.ToLower()))
            {
                throw new Exception($"User with same username '{user.Username}' already exists");
            }

            _db.Users.Add(user);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            else if (await _db.Users.AnyAsync(x => x.Username.ToLower() == user.Username.ToLower() && x.Id != user.Id))
            {
                throw new Exception($"User with same username '{user.Username}' already exists");
            }

            var entity = await _db.Users.FirstOrDefaultAsync(x => x.Id.Equals(user.Id));
            
            if(entity != null)
            {
                entity.FirstName = user.FirstName;
                entity.LastName = user.LastName;
                entity.Username = user.Username;
                entity.Password = user.Password;
                entity.Role = user.Role;
                await _db.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"User with id '{user.Id}' not found");
            }
        }

        public async Task<User> GetAsync(int id)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<User>> GetListAsync()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task<int> LoginAsync(string? username, string? password)
        {
            try
            {
                var any = await _db.Users.AnyAsync(x => string.Equals(x.Username, username) 
                                            && string.Equals(x.Password, password, StringComparison.Ordinal));
                if (any)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
        }
    }
}
