using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Asset
    {
        [Key]
        public int AssetId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [MaxLength(150)]
        public string Url { get; set; }

        [Required]
        [MaxLength(10)]
        public string Format { get; set; }
    }
}
