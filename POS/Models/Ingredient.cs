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
        public string IngredientName { get; set; }

        [Required]
        [MaxLength(200)]
        public string IngredientDescription { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal UnitPrice { get; set;}

        [Required]
        [MaxLength(5)]
        public string Unit {  get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal TotalQuantity { get; set; }

        [Required]
        [MaxLength(128)]
        public string Sku { get; set; }

        [Required]
        public Byte Barcode { get; set; }
    }
}
