using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class ContractService
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string ContractId { get; set; }

        [ForeignKey(nameof(ContractId))]
        public Contract Contract { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
    }
}
