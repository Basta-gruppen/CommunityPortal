using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class Group
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        public List<UserGroup> UserGroups { get; set; }
        public List<SubForumGroup> SubForumGroups { get; set; }
    }
}
