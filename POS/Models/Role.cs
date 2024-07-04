using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Role : IdentityRole
    {

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

    }
}
