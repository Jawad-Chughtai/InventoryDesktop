﻿using Microsoft.EntityFrameworkCore;

namespace InventoryDesktop.EntityFramework.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly InventoryDbContext context;
        public UserRepository(InventoryDbContext context)
        {
            this.context = context;
        }

        public async Task<User> CreateAsync(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            else if (await context.Users.AnyAsync(x => x.Username.ToLower() == user.Username.ToLower()))
            {
                throw new Exception($"'{user.Username}' already taken");
            }

            context.Users.Add(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateAsync(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            else if (await context.Users.AnyAsync(x => x.Username.ToLower() == user.Username.ToLower() && x.Id != user.Id))
            {
                throw new Exception($"User with same username '{user.Username}' already exists");
            }

            var entity = await context.Users.FirstOrDefaultAsync(x => x.Id.Equals(user.Id));

            if (entity != null)
            {
                entity.FirstName = user.FirstName;
                entity.LastName = user.LastName;
                entity.Username = user.Username;
                entity.Password = user.Password;
                entity.Role = user.Role;
                await context.SaveChangesAsync();
                return entity;
            }
            else
            {
                throw new Exception($"User with id '{user.Id}' not found");
            }
        }

        public async Task<User> GetAsync(int id)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<User>> GetListAsync()
        {
            return await context.Users.Where(x => x.IsIncluded && !x.IsDeleted).OrderBy(x => x.Role).ToListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception($"User with id '{id}' not found");
            user.IsDeleted = true;
            await context.SaveChangesAsync();
        }

        public async Task<User> LoginAsync(string? username, string? password)
        {
            var user = await context.Users
                    .FirstOrDefaultAsync(x =>
                    x.Username == username
                    && x.Password == password
                    && !x.IsDeleted);
            if (user != null)
            {
                var usernamecheck = string.Equals(user.Username, username);
                var passwordcheck = string.Equals(user.Password, password);

                if (usernamecheck && passwordcheck)
                {
                    return user;
                }

                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<User> GetSuperAdminAsync(string role)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Role.Equals(role));
        }
    }
}
