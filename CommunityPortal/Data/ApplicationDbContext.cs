using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

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

            #region Relations
            
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

            #endregion

            #region SeedData

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            List<ApplicationUser> applicationUsers = new List<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = "seeduser@gmail.com",
                    NormalizedEmail = "SEEDUSER@GMAIL.COM",
                    UserName = "SeedUser",
                    NormalizedUserName = "SEEDUSER",
                    PasswordHash = passwordHasher.HashPassword(null, "password"),
                    ImageURL = "https://i.pravatar.cc/100?img=2"
                },
                new ApplicationUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = "seeduser2@gmail.com",
                    NormalizedEmail = "SEEDUSER2@GMAIL.COM",
                    UserName = "SeedUser2",
                    NormalizedUserName = "SEEDUSER2",
                    PasswordHash = passwordHasher.HashPassword(null, "password"),
                    ImageURL = "https://i.pravatar.cc/100?img=4"
                }
            };
            builder.Entity<ApplicationUser>().HasData(applicationUsers);
            
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Gaming"
                },
                new Category()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Health & Safety"
                }
            };
            builder.Entity<Category>().HasData(categories);

            List<CategorySubscriber> categorySubscribers = new List<CategorySubscriber>()
            {
                new CategorySubscriber()
                {
                    UserId = applicationUsers[0].Id,
                    CategoryId = categories[0].Id
                },
                new CategorySubscriber()
                {
                    UserId = applicationUsers[0].Id,
                    CategoryId = categories[1].Id
                },
                new CategorySubscriber()
                {
                    UserId = applicationUsers[1].Id,
                    CategoryId = categories[1].Id
                }
            };
            builder.Entity<CategorySubscriber>().HasData(categorySubscribers);

            Conversation conversation = new Conversation()
            {
                Id = Guid.NewGuid().ToString(),
                Subject = "A cool conversation between seeded users"
            };
            builder.Entity<Conversation>().HasData(conversation);

            List<Event> events = new List<Event>()
            {
                new Event()
                {
                    Id = Guid.NewGuid().ToString(),
                    Subject = "Meeting in town centre",
                    Content = "We will be meeting in the town centre on the specified date.",
                    UserId = applicationUsers[0].Id,
                    Timestamp = DateTime.Now,
                    StartDate = DateTime.Now.AddDays(3)
                },
                new Event()
                {
                    Id = Guid.NewGuid().ToString(),
                    Subject = "Riot at Walmart",
                    Content = "We will begin a riot on Walmart on the second street",
                    UserId = applicationUsers[1].Id,
                    Timestamp = DateTime.Now,
                    StartDate = DateTime.Now.AddDays(10)
                }
            };
            builder.Entity<Event>().HasData(events);

            List<Forum> forums = new List<Forum>()
            {
                new Forum()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Programming"
                },
                new Forum()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Gaming"
                }
            };
            builder.Entity<Forum>().HasData(forums);

            List<Group> groups = new List<Group>()
            {
                new Group()
                {
                    Id = Guid.NewGuid().ToString(),
                    OwnerId = applicationUsers[0].Id,
                    Name = "Gamers"
                },
                new Group()
                {
                    Id = Guid.NewGuid().ToString(),
                    OwnerId = applicationUsers[1].Id,
                    Name = "Programmers"
                },
                new Group()
                {
                    Id = Guid.NewGuid().ToString(),
                    OwnerId = applicationUsers[0].Id,
                    Name = "General"
                }
            };
            builder.Entity<Group>().HasData(groups);

            List<Message> messages = new List<Message>()
            {
                new Message()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserId = applicationUsers[0].Id,
                    ConversationId = conversation.Id,
                    Content = "Hello my dear friend, how are you doing?",
                    TimeStamp = DateTime.Now
                },
                new Message()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserId = applicationUsers[1].Id,
                    ConversationId = conversation.Id,
                    Content = "Hi! I'm doing great, thanks for asking!!",
                    TimeStamp = DateTime.Now.AddHours(3)
                }
            };
            builder.Entity<Message>().HasData(messages);

            List<Post> posts = new List<Post>()
            {
                new Post()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserId = applicationUsers[0].Id,
                    CategoryId = categories[0].Id,
                    Subject = "This is my first post (:",
                    Content = "Thank you so much for reading my first post, it means a lot to me!",
                    Timestamp = DateTime.Now
                },
                new Post()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserId = applicationUsers[1].Id,
                    CategoryId = categories[1].Id,
                    Subject = "So I made my first post today..",
                    Content = "Hey so I made my first post today, and this it! It's not much but it's something.",
                    Timestamp = DateTime.Now
                }
            };
            builder.Entity<Post>().HasData(posts);

            List<Tag> tags = new List<Tag>()
            {
                new Tag()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "First Post"
                },
                new Tag()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Informative"
                },
                new Tag()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Casual"
                }
            };
            builder.Entity<Tag>().HasData(tags);

            List<PostTag> postTags = new List<PostTag>()
            {
                new PostTag()
                {
                    PostId = posts[0].Id,
                    TagId = tags[0].Id
                },
                new PostTag()
                {
                    PostId = posts[0].Id,
                    TagId = tags[1].Id
                },
                new PostTag()
                {
                    PostId = posts[1].Id,
                    TagId = tags[0].Id
                },
                new PostTag()
                {
                    PostId = posts[1].Id,
                    TagId = tags[2].Id
                }
            };
            builder.Entity<PostTag>().HasData(postTags);

            List<SubForum> subForums = new List<SubForum>()
            {
                new SubForum()
                {
                    Id = Guid.NewGuid().ToString(),
                    ForumId = forums[0].Id,
                    Name = "C#",
                    Description = "All programming related to the C# language and it's frameworks",
                    OwnerId = applicationUsers[0].Id
                },
                new SubForum()
                {
                    Id = Guid.NewGuid().ToString(),
                    ForumId = forums[1].Id,
                    Name = "League of Legends",
                    Description = "SubForum about the game League of Legends",
                    OwnerId = applicationUsers[0].Id
                },
                new SubForum()
                {
                    Id = Guid.NewGuid().ToString(),
                    ForumId = forums[1].Id,
                    Name = "Minecraft",
                    Description = "Everything about Minecraft",
                    OwnerId = applicationUsers[0].Id
                }
            };
            builder.Entity<SubForum>().HasData(subForums);

            List<SubForumGroup> subForumGroups = new List<SubForumGroup>()
            {
                new SubForumGroup()
                {
                    GroupId = groups[0].Id,
                    SubForumId = subForums[1].Id
                },
                new SubForumGroup()
                {
                    GroupId = groups[0].Id,
                    SubForumId = subForums[2].Id
                },
                new SubForumGroup()
                {
                    GroupId = groups[1].Id,
                    SubForumId = subForums[0].Id
                }
            };
            builder.Entity<SubForumGroup>().HasData(subForumGroups);

            List<Thread> threads = new List<Thread>()
            {
                new Thread()
                {
                    Id = Guid.NewGuid().ToString(),
                    Subject = "How do I print text?",
                    UserId = applicationUsers[0].Id,
                    SubForumId = subForums[0].Id,
                    TimeStamp = DateTime.Now
                },
                new Thread()
                {
                    Id = Guid.NewGuid().ToString(),
                    Subject = "Why League is the most toxic game",
                    UserId = applicationUsers[1].Id,
                    SubForumId = subForums[1].Id,
                    TimeStamp = DateTime.Now.AddDays(1)
                },
                new Thread()
                {
                    Id = Guid.NewGuid().ToString(),
                    Subject = "Where to find diamonds?",
                    UserId = applicationUsers[1].Id,
                    SubForumId = subForums[2].Id,
                    TimeStamp = DateTime.Now.AddHours(6)
                }
            };
            builder.Entity<Thread>().HasData(threads);

            List<Reply> replies = new List<Reply>()
            {
                new Reply()
                {
                    Id = Guid.NewGuid().ToString(),
                    ThreadId = threads[0].Id,
                    UserId = applicationUsers[0].Id,
                    Content = "I've been trying really long to figure how to print text but I just get errors plz help",
                    TimeStamp = DateTime.Now
                },
                new Reply()
                {
                    Id = Guid.NewGuid().ToString(),
                    ThreadId = threads[0].Id,
                    UserId = applicationUsers[1].Id,
                    Content = "Use google.",
                    TimeStamp = DateTime.Now.AddHours(5)
                },
                new Reply()
                {
                    Id = Guid.NewGuid().ToString(),
                    ThreadId = threads[1].Id,
                    UserId = applicationUsers[1].Id,
                    Content = "This is the most toxic game ever, everybody is just flaming. I QUIT!!!",
                    TimeStamp = DateTime.Now
                },
                new Reply()
                {
                    Id = Guid.NewGuid().ToString(),
                    ThreadId = threads[1].Id,
                    UserId = applicationUsers[0].Id,
                    Content = "lol noob",
                    TimeStamp = DateTime.Now.AddHours(4)
                },
                new Reply()
                {
                    Id = Guid.NewGuid().ToString(),
                    ThreadId = threads[1].Id,
                    UserId = applicationUsers[1].Id,
                    Content = "COME 1V1 ME",
                    TimeStamp = DateTime.Now.AddHours(6)
                },
                new Reply()
                {
                    Id = Guid.NewGuid().ToString(),
                    ThreadId = threads[2].Id,
                    UserId = applicationUsers[1].Id,
                    Content = "I can't find diamonds anywhere, it's really hard :(",
                    TimeStamp = DateTime.Now
                },
                new Reply()
                {
                    Id = Guid.NewGuid().ToString(),
                    ThreadId = threads[2].Id,
                    UserId = applicationUsers[1].Id,
                    Content = "I thinks it's below y-level 12 try that! ((:",
                    TimeStamp = DateTime.Now.AddHours(2)
                }
            };
            builder.Entity<Reply>().HasData(replies);

            List<UserConversation> userConversations = new List<UserConversation>()
            {
                new UserConversation()
                {
                    UserId = applicationUsers[0].Id,
                    ConversationId = conversation.Id
                },
                new UserConversation()
                {
                    UserId = applicationUsers[1].Id,
                    ConversationId = conversation.Id
                }
            };
            builder.Entity<UserConversation>().HasData(userConversations);

            List<UserGroup> userGroups = new List<UserGroup>()
            {
                new UserGroup()
                {
                    UserId = applicationUsers[0].Id,
                    GroupId = groups[0].Id
                },
                new UserGroup()
                {
                    UserId = applicationUsers[0].Id,
                    GroupId = groups[1].Id
                },
                new UserGroup()
                {
                    UserId = applicationUsers[1].Id,
                    GroupId = groups[0].Id
                },
                new UserGroup()
                {
                    UserId = applicationUsers[1].Id,
                    GroupId = groups[1].Id
                }
            };
            builder.Entity<UserGroup>().HasData(userGroups);

            #endregion

        }

    }
}