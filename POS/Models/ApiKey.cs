using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class ApiKey
    {
        [Key]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [MaxLength(128)]
        public string Apikey { get; set; }

        [ForeignKey(nameof(Email))]
        public User User { get; set; }
    }
}
