using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Invoice
    {
        [Key]
        [MaxLength(128)]
        public string InvoiceId { get; set; }

        [Required]
        [StringLength(128)]
        public string OrderId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        [Precision(28, 6)]
        public decimal Cost { get; set; }
    }
}
