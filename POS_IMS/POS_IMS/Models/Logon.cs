using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Logon
    {
        [Key]
        public int LogonId { get; set; }

        [Required]
        [MaxLength(150)]
        public string UserName { get; set; }

        [Required]
        public DateTime Login { get; set; }

        public DateTime LogOff { get; set; }

        [Required]
        public int Location { get; set; }

        [Required]
        public string TokenId { get; set; }

        [ForeignKey(nameof(Location))]

        public GPS GPS { get; set; }


        [ForeignKey(nameof(TokenId))]

        public Session Session { get; set; }



    }
}
