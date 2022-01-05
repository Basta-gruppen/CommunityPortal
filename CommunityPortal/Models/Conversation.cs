using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class Conversation
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Subject { get; set; }

        public List<ApplicationUser> Users { get; set; }
        public List<Message> Messages { get; set; }
    }
}
