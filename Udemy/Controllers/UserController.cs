using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Udemy.Controllers
{
    public class UserController : Controller
    {


        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var viewModel = _mapper.Map<IEnumerable<UsersViewModel>>(users);
            return View(viewModel);
        }
    }
}