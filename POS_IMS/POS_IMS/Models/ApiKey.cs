using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace POS.Models
{
    public class ApiKey
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Apikey { get; set; }

        [ForeignKey(nameof(Id))]
        public IdentityUser User { get; set; }
    }
}
