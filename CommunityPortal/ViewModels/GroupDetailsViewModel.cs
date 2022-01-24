using System.Collections.Generic;
using CommunityPortal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CommunityPortal.ViewModels
{
    public class GroupDetailsViewModel
    {
        public Group Group { get; set; }
        public IEnumerable<ApplicationUser> Members { get; set; }
        public ApplicationUser Owner { get; set; }
        public bool IsOwner { get; set; }
    }
}