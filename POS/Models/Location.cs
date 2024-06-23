using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required]
        [MaxLength(10)]
        public string LocationDescription { get; set; }
    }
}
