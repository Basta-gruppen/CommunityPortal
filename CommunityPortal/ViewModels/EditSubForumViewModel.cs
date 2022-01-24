using System.Collections.Generic;
using CommunityPortal.Models;

namespace CommunityPortal.ViewModels
{
    public class EditSubForumViewModel
    {
        public SubForum SubForum { get; set; }
        public IEnumerable<Forum> Forums { get; set; }
    }
}