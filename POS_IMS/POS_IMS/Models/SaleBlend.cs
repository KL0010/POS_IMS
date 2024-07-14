using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class SaleBlend
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string SaleId { get; set; }

        [ForeignKey(nameof(SaleId))]

        public Sale Sale { get; set; }

        [Required]
        public int BlendId { get; set; }

        [ForeignKey(nameof(BlendId))]

        public Blend Blend  { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal UnitPrice { get; set; }

        [Required]
        public string Unit { get; set; }

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
        public decimal LineTotal { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal Margin { get; set; }

        [MaxLength(200)]
        public string Note { get; set; }
    }
}
