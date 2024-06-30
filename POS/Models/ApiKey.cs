using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class ApiKey
    {
        [Key]
        [MaxLength(128)]
        public string Username { get; set; }

        [Required]
        [MaxLength(128)]
        public string Apikey { get; set; }

        [ForeignKey(nameof(Username))]
        public User User { get; set; }
    }
}
