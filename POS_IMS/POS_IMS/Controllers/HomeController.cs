using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Models;
using POS_IMS.Data;
using POS_IMS.Models;
using System.Diagnostics;

namespace POS_IMS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<ActionResult> IndexAsync()
        {
            var usr = await _userManager.GetUserAsync(User);

            if (usr != null) {
                var homeUser = _context.Homes.FirstOrDefault(acc => acc.UserId == usr.Id);

                return View(homeUser);
            }

            return BadRequest("An Error has occurred...");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
