using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

    }
}
