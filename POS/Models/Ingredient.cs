using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        [Required]
        [MaxLength(30)]
        public string IngredientName { get; set; }

        [Required]
        [MaxLength(200)]
        public string IngredientDescription { get; set; }
    }
}
