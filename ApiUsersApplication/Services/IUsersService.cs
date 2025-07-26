using ApiUsersApplication.Models;

namespace ApiUsersApplication.Services
{
    public interface IUsersService
    {
        Task SaveUsersAsync(string apiRequest);
        Task<List<Users>> GetAllUsersAsync();
    }
}
