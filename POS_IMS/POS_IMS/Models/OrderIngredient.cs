using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class OrderIngredient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }

        [Required]
        public int IngredientId { get; set; }

        [ForeignKey(nameof(IngredientId))]
        public Ingredient Ingredient { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal Quantity { get; set; }

        [Required]
        public bool Shipped { get; set; }

        [Required]
        public bool Invoiced { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal UnitPrice { get; set; }

        [Required]
        public string Unit {  get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal Discount { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal DiscountPrice { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal TaxRate { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal LineTotal { get;set; }

        [Required]
        [Precision(28, 6)]
        public decimal Margin { get; set; }
    }
}
