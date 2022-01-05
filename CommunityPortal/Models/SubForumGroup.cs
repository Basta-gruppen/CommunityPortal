using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class SubForumGroup
    {
        [Required]
        public string SubForumId { get; set; }
        [Required]
        public string GroupId { get; set; }

        public Group Group { get; set; }
        public SubForum SubForum {get;set;}
    }
}
