using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tp5.Data;

namespace Tp5.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public AccountController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult UserManagement()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
    }
}
