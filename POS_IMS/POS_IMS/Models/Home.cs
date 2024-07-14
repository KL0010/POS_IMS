using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Home
    {
        [Key]
        [MaxLength(450)]
        public required string HomeId { get; set; }

        [Required]
        [MaxLength(450)]
        public required string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public required IdentityUser User { get; set; }

        public required string Configuration {  get; set; }

    }
}
