using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class Message
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Content { get; set; }
        [Required]
        public string UserId { get; set; }

        [Required]
        public string ConversationId { get; set; }

        public Conversation Conversation { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        public ApplicationUser User { get; set; }
    }
}
