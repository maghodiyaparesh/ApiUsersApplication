using ApiUsersApplication.Models;

namespace ApiUsersApplication.Services
{
    public interface IConvertService
    {
        List<Users> ConvertToUsers(string apiRequest);
    }
}
