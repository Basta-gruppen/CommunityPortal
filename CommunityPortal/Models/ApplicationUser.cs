using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ImageURL { get; set; }
        public List<UserGroup> UserGroups { get; set; }
        public List<Thread> Threads { get; set; }

        public List<Reply> Replies { get; set; }
        public List<UserConversation> UserConversations { get; set; }

        public List<Message> Messages { get; set; }

        public List<Event> Events { get; set; }

        public List<CategorySubscriber> CategorySubscribers { get; set; }

        public List<Post> Posts { get; set; }
    }
}
