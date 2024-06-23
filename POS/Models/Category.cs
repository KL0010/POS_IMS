using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(20)]
        public string CategoryName { get; set; }

        [Required]
        [MaxLength(200)]
        public string CategoryDescription { get; set; }

    }
}
