using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Assesmbly
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string BlendName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Assemble { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
    }
}
