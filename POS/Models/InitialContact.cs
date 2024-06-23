using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class InitialContact
    {
        [Key]
        [MaxLength(150)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(150)]
        public string Address { get; set; }
        [Required]
        [MaxLength(30)]
        public string Borough { get; set; }
        [Required]
        [MaxLength(20)]
        public string State { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
        [Required]
        [MaxLength(10)]
        public string Postcode { get; set; }
        [Required]
        [MaxLength(15)]
        public string BusinessId { get; set; }
        [Required]
        [MaxLength(100)]
        public string LegalBusinessName { get; set; }
        [Required]
        [MaxLength(100)]
        public string PhoneNumer { get; set; }
        [Required]
        [MaxLength(200)]
        public string Brands { get; set; }
        [Required]
        public DateTime ContactDate { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Message { get; set; }
        [Required]
        public bool Resolved { get; set; }
    }
}
