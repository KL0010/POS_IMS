using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Country_Name { get; set; }
    }
}
