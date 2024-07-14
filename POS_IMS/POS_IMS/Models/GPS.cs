using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class GPS
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public double Latitude { get; set; }
    }
}
