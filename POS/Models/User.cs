using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class User
    {
        [Key]
        [MaxLength(128)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email  { get; set; }

        [Required]
        public byte[] Password { get; set; }

        [Required]
        public byte[] Salt { get; set; }

        [Required]
        public int RoleId { get; set; }

        [ForeignKey(nameof(Email))]
        public InitialContact InitialContact { get; set; }
    }
}
