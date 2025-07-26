using ApiUsersApplication.Models;

namespace ApiUsersApplication.Repositories
{
    public interface IUsersRepository
    {
        Task AddAsync(Users users);
        Task AddRangeAsync(IEnumerable<Users> users);
        Task<List<Users>> GetAllAsync();
    }
}
