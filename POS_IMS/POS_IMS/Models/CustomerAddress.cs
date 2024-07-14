using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class CustomerAddress
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]

        public Address Address { get; set; }

        [Required]
        [MaxLength(450)]
        public string CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]

        public Customer Customer { get; set; }
    }
}
