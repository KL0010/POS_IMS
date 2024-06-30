using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class SupplierIngredient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string SupplierId { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal Quantity { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal Cost { get; set; }

        [Required]
        public int IngredientId { get; set; }

        [ForeignKey(nameof(IngredientId))]
        public Ingredient Ingredient { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        [MaxLength(128)]
        public string InvoiceId { get; set; }
    }
}
