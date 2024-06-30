using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Quantity
    {
        [Key]
        public int QuantityId { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal Price { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public int BlendId { get; set; }

        [ForeignKey(nameof(BlendId))]
        public Blend Blend { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal Weight { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal UnitPrice { get; set; }

        [Required]
        [MaxLength(5)]
        public string Unit {  get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal TotalQuantity { get; set;}

    }
}
