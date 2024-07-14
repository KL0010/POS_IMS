using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class BusinessIdentifier
    {
        [Key]
        [MaxLength(10)]
        public string Acronym { get; set; }
        [Required]
        [MaxLength(50)]
        public string Country{ get; set; }

    }
}
