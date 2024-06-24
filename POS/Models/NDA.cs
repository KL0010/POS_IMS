using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class NDA
    {
        [Key]
        public string NdaId { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Agreement { get; set; }

        [Required]
        public DateTime Creationdate { get; set; }

        [Required]
        [MaxLength(128)]
        public string ContractId { get; set; }

        [ForeignKey(nameof(ContractId))]

        public Contract Contract { get; set; }
    }
}
