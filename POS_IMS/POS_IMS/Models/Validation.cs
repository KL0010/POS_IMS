
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Validation
    {
        [Key]
        [MaxLength(256)]
        public string Email { get; set; }

        [Required]
        public bool Confirmed { get; set; }

        [Required]
        public short Input1 { get; set; }

        [Required]
        public short Input2 { get; set; }

        [Required]
        public short Input3 { get; set; }

        [Required]
        public short Input4 { get; set; }

        [ForeignKey(nameof(Email))]
        public InitialContact InitialContacts { get; set; }
    }
}
