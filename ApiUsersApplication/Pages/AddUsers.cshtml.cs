using ApiUsersApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApiUsersApplication.Pages
{
    public class AddUsersModel : PageModel
    {
        private readonly IUsersService _usersService;

        public AddUsersModel(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public string ApiRequest { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(ApiRequest))
            {
                ModelState.AddModelError(string.Empty, "API request cannot be empty.");
                return Page();
            }

            try
            {
                await _usersService.SaveUsersAsync(ApiRequest);
                return RedirectToPage("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"An error occurred while saving users: {ex.Message}");
                return Page();
            }
        }
    }
}
