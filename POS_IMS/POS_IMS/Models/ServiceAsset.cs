using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class ServiceAsset
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [MaxLength(150)]
        public string Url { get; set; }

        [Required]
        [MaxLength(10)]
        public string FormatType { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; }
    }
}
