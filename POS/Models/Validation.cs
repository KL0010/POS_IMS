
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Validation
    {
        [Key]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        public bool Confirmed { get; set; }

        public short Input1 { get; set; }

        public short Input2 { get; set; }

        public short Input3 { get; set; }

        public short Input4 { get; set; }

        [ForeignKey(nameof(Email))]

        public InitialContact InitialContacts { get; set; }
    }
}
