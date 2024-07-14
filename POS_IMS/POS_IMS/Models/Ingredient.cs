using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace POS.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        [Required]
        [MaxLength(30)]
        public required string IngredientName { get; set; }

        [Required]
        [MaxLength(200)]
        public required string IngredientDescription { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal UnitPrice { get; set;}

        [Required]
        [MaxLength(5)]
        public required string Unit {  get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal TotalQuantity { get; set; }

        [Required]
        [MaxLength(128)]
        public required string Sku { get; set; }

        [Required]
        public Byte Barcode { get; set; }
    }
}
