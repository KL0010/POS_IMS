using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS.Models;
using POS.DTO;
using System.Security.Cryptography;
using System.Text;

namespace POS.Controllers
{
    public class AccountController : BaseController
    {
        private readonly DataContext _context;

        public AccountController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("api/register")]
        public async Task<ActionResult<User>> Register(RegisterDto model)
        {
            if (await UserExits(model.Username.ToLower()))
            {
                return BadRequest("Username has been taken.");
            }
            using var hmac = new HMACSHA512();
            var user = new User
            {
                UserName = model.Username.ToLower(),
                Email = model.Email,
                RoleId = 0, // Default value for all users.
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(model.Password)),
                Salt = hmac.Key,
                
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<bool> UserExits(string username)
        {
            return await _context.Users.AnyAsync(x => x.UserName == username);
        }
    }
}
