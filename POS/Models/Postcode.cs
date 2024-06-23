using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Postcode
    {
        [Key]
        public int PostcodeId { get; set; }

        [Required]
        [MaxLength(10)]
        public string PostcodeNumber { get; set; }

        [Required]
        public int StateId { get; set; }

        [ForeignKey(nameof(StateId))]

        public State State { get; set; }
    }
}
