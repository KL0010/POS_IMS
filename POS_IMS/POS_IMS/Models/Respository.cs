using Microsoft.AspNetCore.Mvc.RazorPages;
using POS_IMS.Data;

namespace POS_IMS.Models
{
    public class Respository : PageModel
    {
        private ApplicationDbContext _context;

        public Respository() { }

    }
}
