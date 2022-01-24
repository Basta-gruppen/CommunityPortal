using System.Collections.Generic;
using CommunityPortal.Models;

namespace CommunityPortal.ViewModels
{
    public class GroupViewModel
    {
        public IEnumerable<Group> Groups { get; set; }
        public Group newGroup { get; set; }
    }
}