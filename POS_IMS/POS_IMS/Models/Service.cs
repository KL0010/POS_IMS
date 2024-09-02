using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        public string ServiceDescription { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
    }
}
