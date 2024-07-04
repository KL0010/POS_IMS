using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Conversation
    {
        [Key]
        public int ConversationId { get; set; }

        [Required]
        [MaxLength(450)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Comment { get; set; }

        [Required]
        public DateTime PostDate { get; set; }

        [Required]
        [MaxLength(256)]
        public string ContactId { get; set; }

        [ForeignKey(nameof(ContactId))]
        public InitialContact InitialContact { get; set; }
    }
}
