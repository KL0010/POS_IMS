using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using POS_IMS.Models;

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

        [HttpPost]
        public bool GetMobile(string phoneNumber)
        {
            return _userManager.Users.Any(x => x.PhoneNumber == phoneNumber);
        }

        [HttpPost]
        public string GetAddressKey()
        {
            Init init = new Init();
            string addresskey = init.AutoAddressKey;
            return addresskey;
        }
    }
}
