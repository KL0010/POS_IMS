using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace POS.Models
{
    public class IngredientLocation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int  IngredientId { get; set; }

        [ForeignKey(nameof(IngredientId))]

        public Ingredient Ingredient { get; set; }

        [Required]
        public int LocationId { get; set; }

        [ForeignKey(nameof(LocationId))]

        public Location Location { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal QuantityAmount { get; set; }
    }
}
