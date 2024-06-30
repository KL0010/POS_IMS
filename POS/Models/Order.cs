using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Order
    {
        [Key]
        [MaxLength(128)]
        public string OrderId { get; set; }

        [Required]
        [StringLength(128)]
        public string CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        [Required]
        [MaxLength(120)]
        public string Ingredients { get; set; } // Stores the id of each ingredent

        [Required]
        [Precision(28, 6)]
        public decimal TotalAmount { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public string Note { get; set; }



    }
}
