using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class BlendIngredient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BlendId { get; set; }

        [ForeignKey(nameof(BlendId))]

        public Blend Blend { get; set; }

        [Required]
        public int IngredientId { get; set; }

        [ForeignKey(nameof(IngredientId))]

        public Ingredient Ingredient{ get; set; }
    }
}
