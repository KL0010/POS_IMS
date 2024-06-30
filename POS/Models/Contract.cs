using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Contract
    {
        [Key]
        [MaxLength(128)]
        public string ContractId { get; set; }

        [Required]
        [MaxLength(50)]
        public string LegalBusinessName { get; set; }

        [Required]
        [MaxLength(20)]
        public string BusinessIdNumber { get; set; }

        [Required]
        [MaxLength(10)]
        public string Type { get; set; }

        [Required]
        [MaxLength(128)]
        public string CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]

        public Customer Customer { get; set; }

        [Required]
        [MaxLength(128)]
        public string Approver { get; set; }

        [ForeignKey(nameof(Approver))]

        public User User { get; set; }
    }
}
