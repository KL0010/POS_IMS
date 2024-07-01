using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace POS.Controllers
{
    public class RoleController : BaseController
    {
        private readonly DataContext context;

        public RoleController(DataContext context) { 
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> Get() {
            var roles = await context.Roles.ToListAsync();
            return roles;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Role>> Get(int id)
        {
            var role = await context.Roles.FindAsync(id);

            if (role == null)
            {
                return NotFound();
            }

            return role;
        }
    }
}
