using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Origin
    {
        [Key]
        public int OriginId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Country{ get; set; }

    }
}
