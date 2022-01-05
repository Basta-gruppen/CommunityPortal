using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class UserGroup
    {
        public string GroupId { get; set; }

        public string UserId { get; set; }
        public Group Group { get; set; }

        public ApplicationUser User { get; set; }
    }
}
