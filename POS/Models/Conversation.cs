using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Conversation
    {
        [Key]
        public int ConversationId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Comment { get; set; }

        [Required]
        public DateTime PostDate { get; set; }

        [Required]
        [MaxLength(150)]
        public string UserName { get; set; }

        [ForeignKey(nameof(UserName))]

        public User User { get; set; }
    }
}
