using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class IngredientOrigin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IngredientId { get; set; }

        [ForeignKey(nameof(IngredientId))]

        public Ingredient Ingredient { get; set; }

        [Required]
        public int OriginId { get; set; }

        [ForeignKey(nameof(OriginId))]

        public Origin Origin { get; set; }
    }
}
