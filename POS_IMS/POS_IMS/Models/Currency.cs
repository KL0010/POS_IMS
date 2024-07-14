using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Currency
    {
        [Key]
        public int CurrencyId { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Currency")]
        public string CurrencyAbbreviation{ get; set; }
    }
}
