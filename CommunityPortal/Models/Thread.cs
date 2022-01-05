using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class Thread
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Subject { get; set; }
        [Required]
        public string SubForumId { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
        public SubForum SubForum { get; set; }

        public List<Reply> Replies { get; set; }
    }
}
