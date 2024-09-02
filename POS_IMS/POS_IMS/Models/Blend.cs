using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Blend
    {
        [Key]
        public int BlendId { get; set; }

        [Required]
        [MaxLength(30)]
        public string BlendName { get; set; }

        [Required]
        [MaxLength(128)]
        public string Sku { get; set; }

        [Required]
        public Byte Barcode{ get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(150)]
        public string ImageUrl { get; set; }

        [ForeignKey(nameof(CategoryId))]

        public Category Category { get; set; }

        public IEnumerable <Ingredient> Ingredients { get; set;}
    }
}
