using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class SubForum
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string ForumId { get; set; }

        public Forum Forum { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public string OwnerId { get; set; }

        public List<SubForumGroup> SubForumGroups { get; set; }

        public List<Thread> Threads { get; set; }

    }
}
