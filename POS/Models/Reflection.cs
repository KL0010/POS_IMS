using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Reflection
    {
        [Key]
        public int ReflectionId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string ReflectionComment { get; set; }

        [Required]
        public int BlendId { get; set; }

        [ForeignKey(nameof(BlendId))]
        public Blend Blend { get; set; }
    }
}
