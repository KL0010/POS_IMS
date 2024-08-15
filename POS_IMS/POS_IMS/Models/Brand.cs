using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        [Required]
        [MaxLength(50)]
        public string BrandName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LogoUrl { get; set; }

        [Required]
        [MaxLength (10)]
        public string FormatType { get; set;}

        [Required]
        [MaxLength(128)]
        public string ContractId { get; set; }

        [ForeignKey(nameof(ContractId))]

        public Contract Contract { get; set; }

        [Required]
        public string Description{ get; set; }
    }
}
