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
        
        public DbSet<Category> Categories { get; set; }                     //
        public DbSet<CategorySubscriber> CategorySubscribers { get; set; }  //
        public DbSet<Conversation> Conversations { get; set; }              //
        public DbSet<Event> Events { get; set; }                            //
        public DbSet<Forum> Forums { get; set; }                            //
        public DbSet<Group> Groups { get; set; }                            //
        public DbSet<Message> Messages { get; set; }                        //
        public DbSet<Post> Posts { get; set; }                              //
        public DbSet<PostTag> PostTags { get; set; }                        //
        public DbSet<Reply> Replies { get; set; }                           //
        public DbSet<SubForum> SubForums { get; set; }                      //
        public DbSet<SubForumGroup> SubForumGroups { get; set; }            //
        public DbSet<Tag> Tags { get; set; }                                //
        public DbSet<Thread> Threads { get; set; }                          //
        public DbSet<UserConversation> UserConversations { get; set; }      //
        public DbSet<UserGroup> UserGroups { get; set; }                    //

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserGroup>().HasKey(ug => new {ug.UserId, ug.GroupId});
            builder.Entity<UserGroup>()
                .HasOne(ug => ug.User)
                .WithMany(u => u.UserGroups)
                .HasForeignKey(ug => ug.UserId);
            builder.Entity<UserGroup>()
                .HasOne(ug => ug.Group)
                .WithMany(g => g.UserGroups)
                .HasForeignKey(ug => ug.GroupId);

            builder.Entity<UserConversation>().HasKey(uc => new {uc.UserId, uc.ConversationId});
            builder.Entity<UserConversation>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserConversations)
                .HasForeignKey(uc => uc.UserId);
            builder.Entity<UserConversation>()
                .HasOne(uc => uc.Conversation)
                .WithMany(c => c.UsersConversations)
                .HasForeignKey(uc => uc.ConversationId);

            builder.Entity<SubForumGroup>().HasKey(sfg => new {sfg.GroupId, sfg.SubForumId});
            builder.Entity<SubForumGroup>()
                .HasOne(sfg => sfg.SubForum)
                .WithMany(sf => sf.SubForumGroups)
                .HasForeignKey(sfg => sfg.SubForumId);
            builder.Entity<SubForumGroup>()
                .HasOne(sfg => sfg.Group)
                .WithMany(g => g.SubForumGroups)
                .HasForeignKey(sfg => sfg.GroupId);

            builder.Entity<PostTag>().HasKey(pt => new {pt.PostId, pt.TagId});
            builder.Entity<PostTag>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId);
            builder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId);

            builder.Entity<CategorySubscriber>().HasKey(cs => new {cs.CategoryId, cs.UserId});
            builder.Entity<CategorySubscriber>()
                .HasOne(cs => cs.Category)
                .WithMany(c => c.CategorySubscribers)
                .HasForeignKey(cs => cs.CategoryId);
            builder.Entity<CategorySubscriber>()
                .HasOne(cs => cs.User)
                .WithMany(u => u.CategorySubscribers)
                .HasForeignKey(cs => cs.UserId);

            builder.Entity<Thread>().HasKey(t => t.Id);
            builder.Entity<Thread>()
                .HasMany(t => t.Replies)
                .WithOne(r => r.Thread)
                .HasForeignKey(r => r.ThreadId);

            builder.Entity<SubForum>().HasKey(sf => sf.Id);
            builder.Entity<SubForum>()
                .HasMany(sf => sf.Threads)
                .WithOne(t => t.SubForum)
                .HasForeignKey(t => t.SubForumId);

            builder.Entity<Forum>().HasKey(f => f.Id);
            builder.Entity<Forum>()
                .HasMany(f => f.SubForums)
                .WithOne(sf => sf.Forum)
                .HasForeignKey(sf => sf.ForumId);

            builder.Entity<Conversation>().HasKey(c => c.Id);
            builder.Entity<Conversation>()
                .HasMany(c => c.Messages)
                .WithOne(m => m.Conversation)
                .HasForeignKey(m => m.ConversationId);

            builder.Entity<Category>().HasKey(c => c.Id);
            builder.Entity<Category>()
                .HasMany(c => c.Posts)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
            
            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Threads)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);
            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Replies)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);
            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Messages)
                .WithOne(m => m.User)
                .HasForeignKey(m => m.UserId);
            builder.Entity<ApplicationUser>()
                .HasMany(u => u.Events)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);
        }
    }
}