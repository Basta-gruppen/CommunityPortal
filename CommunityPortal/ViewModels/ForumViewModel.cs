using System.Collections;
using System.Collections.Generic;
using CommunityPortal.Models;

namespace CommunityPortal.ViewModels
{
    public class ForumViewModel
    {
        public IEnumerable<Forum> Forums { get; set; }
        public IEnumerable<SubForum> SubForums { get; set; }
    }
}