using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Supplier
    {
        [Key]
        [MaxLength(128)]
        public string SupplierId { get; set; }

        [Required]
        [MaxLength(50)]
        public string SupplierName { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        [ForeignKey(nameof(CurrencyId))]

        public Currency Currency { get; set; }
    }
}
