using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Sale
    {
        [Key]
        [MaxLength(128)]
        public string SaleId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Blends { get; set;}

        [Required]
        [Precision(28, 6)]
        public decimal TotalCost { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; }

        [Required]
        [MaxLength(450)]
        public string CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }


    }
}
