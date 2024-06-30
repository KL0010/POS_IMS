using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class QuantityLocation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int QuantityId { get; set; }

        [ForeignKey(nameof(QuantityId))]

        public Quantity Quantity { get; set; }

        [Required]
        public int LocationId { get; set;}

        [ForeignKey(nameof(LocationId))]

        public Location Location{ get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
