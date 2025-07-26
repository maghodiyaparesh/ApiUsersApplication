using ApiUsersApplication.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ApiUsersApplication.Models;

namespace ApiUsersApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUsersService _usersService;
        public List<Users> UsersList { get; set; } = new List<Users>();

        public IndexModel(ILogger<IndexModel> logger, IUsersService usersService)
        {
            _logger = logger;
            _usersService = usersService;
        }

        public void OnGet()
        {
            UsersList = _usersService.GetAllUsersAsync().Result;
        }
    }
}
