using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class BrandAsset
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string AssetName { get; set; }

        [Required]
        [MaxLength(150)]
        public string AssetUrl { get; set; }

        [Required]
        [MaxLength(10)]
        public string FormatType { get; set; }

        [Required]   
        public string Description { get; set; }

        [Required]
        public int BrandId { get; set; }

        [ForeignKey(nameof(BrandId))]
        public Brand Brand { get; set; }

    }
}
