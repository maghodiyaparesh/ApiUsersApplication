using ApiUsersApplication.Data;
using ApiUsersApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiUsersApplication.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext _context;

        public UsersRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Users users)
        {
            if (users == null)
                throw new ArgumentNullException(nameof(users));

            await _context.Users.AddAsync(users);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<Users> users)
        {
            if (users == null || !users.Any())
                throw new ArgumentNullException(nameof(users));

            await _context.Users.AddRangeAsync(users);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Users>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
