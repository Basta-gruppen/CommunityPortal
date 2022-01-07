using System;
using System.Collections.Generic;
using System.Text;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        
        #pragma warning disable CS0108, CS0114
        public DbSet<ApplicationUser> Users { get; set; }
        #pragma warning restore CS0108, CS0114
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategorySubscriber> CategorySubscribers { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<SubForum> SubForums { get; set; }
        public DbSet<SubForumGroup> SubForumGroups { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<UserConversation> UserConversations { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            
        }
    }
}