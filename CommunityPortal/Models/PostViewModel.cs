using System.Collections.Generic;
using CommunityPortal.Models;

namespace CommunityPortal.ViewModels
{
    public class PostViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}