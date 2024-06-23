using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name ="Address")]
        public string AddressInfo { get; set; }

        [Required]
        [MaxLength(20)]
        public string Borough {  get; set; }

        [Required]
        public int PostcodeId { get; set; }

        [ForeignKey(nameof(PostcodeId))]

        public Postcode Postcode { get; set; }
    }
}
