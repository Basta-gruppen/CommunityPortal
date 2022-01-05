using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class UserConversation
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string ConversationId { get; set; }

        public ApplicationUser User { get; set; }
        public Conversation Conversation { get; set; }

    }
}
