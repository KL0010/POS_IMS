using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class ReflectionAsset
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ReflectionId { get; set; }

        [ForeignKey(nameof(ReflectionId))]

        public Reflection Reflection { get; set; }

        [Required]
        public int AssetId { get; set; }

        [ForeignKey(nameof(AssetId))]

        public Asset Asset { get; set; }
    }
}
