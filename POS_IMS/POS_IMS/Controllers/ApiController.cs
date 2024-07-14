using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace POS_IMS.Controllers
{
    public class ApiController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ApiController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public bool GetUsername(string username)
        {
            return _userManager.Users.Any(x => x.UserName == username); 
        }

        [HttpPost]
        public bool GetEmail(string email)
        {
            return _userManager.Users.Any(x => x.Email == email);
        }
    }
}
