using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityPortal.Models;

namespace CommunityPortal.ViewModels
{
    public class EditSubForumViewModel
    {
        public SubForum SubForum { get; set; }
        public IEnumerable<Forum> Forums { get; set; }
        public IEnumerable<Group> AvailableGroups { get; set; }
        
        [Required] public List<string> GroupIds { get; set; }
    }
}