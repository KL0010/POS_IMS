using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [Required]
        [MaxLength(20)]
        public string StateName { get; set; }

        [Required]
        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]

        public Country Country { get; set; }
    }
}
