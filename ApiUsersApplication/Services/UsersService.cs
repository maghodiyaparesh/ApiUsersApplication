using ApiUsersApplication.Models;
using ApiUsersApplication.Repositories;

namespace ApiUsersApplication.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IConvertService _convertService;

        public UsersService(IUsersRepository usersRepository, IConvertService convertService)
        {
            _usersRepository = usersRepository;
            _convertService = convertService;
        }

        public async Task SaveUsersAsync(string apiRequest)
        {
            if (string.IsNullOrEmpty(apiRequest))
                throw new ArgumentNullException(nameof(apiRequest));

            var users = _convertService.ConvertToUsers(apiRequest);

            if (users == null)
                throw new InvalidOperationException("Conversion to Users failed.");

            await _usersRepository.AddRangeAsync(users);
        }

        public async Task<List<Users>> GetAllUsersAsync()
        {
            return await _usersRepository.GetAllAsync();
        }
    }
}
