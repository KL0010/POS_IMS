using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class SupplierAddress
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]

        public Address Address { get; set; }

        [Required]
        [MaxLength(128)]
        public string SupplierId { get; set; }

        [ForeignKey(nameof(SupplierId))]

        public Supplier Supplier { get; set; }
    }
}
