using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using CommunityPortal.Controllers;
using CommunityPortal.Data;
using CommunityPortal.Factories;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace CommunityPortal.Repositories
{
    public class PostRepository
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private IQueryable<Post> _posts;

        public PostRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor accessor)
        {
            _context = context;
            _userManager = userManager;
            _accessor = accessor;
        }
        
        private ClaimsPrincipal GetUser() {
            return _accessor?.HttpContext?.User;
        }

        public PostRepository GetAll()
        {
            _posts =
                _context.Posts
                    .Include(post => post.Category)
                    .Include(post => post.User)
                    .Include(post => post.PostTags)
                    .ThenInclude(postTag => postTag.Tag);
                    

            return this;
        }

        public PostRepository ByTag(string tag)
        {
            var posts = _posts
                .Where(
                    post => post.PostTags.Any(postTag => postTag.Tag.Name.Equals(tag))
                );

            if (posts.Any())
            {
                _posts = posts;
            }
            return this;
        }

        public PostRepository ByCategoryName(string category)
        {
            _posts = _posts
                .Where(
                    post => post.Category.Name.Equals(category)
                );
            return this;
        }
        
        public PostRepository ByCategoryNames(string[] categories)
        {
            _posts = _posts
                .Where(
                    post => categories.Contains(post.Category.Name)
                );
            return this;
        }
        
        public PostRepository ByKeyword(string keyword)
        {
            _posts = _posts
                .Where(
                    post => post.Subject.Contains(keyword) 
                            || post.Content.Contains(keyword)
                );
            return this;
        }

        public PostRepository ByUserSubscribedCategory()
        {
            var user = GetUser();
            if (!user.Identity.IsAuthenticated)
            {
                return this;
            }
            
            var userId = _userManager.GetUserId(user);
            
            if (!_context.CategorySubscribers.Any(x => x.UserId.Equals(userId)))
            {
                return this;
            }
            _posts = _posts
                .Join(_context.CategorySubscribers,
                    post => post.CategoryId,
                    categorySubscriber => categorySubscriber.CategoryId,
                    (post, categorySubscriber) => new
                    {
                        Post = post, categorySubscriber.UserId
                    }
                ).Where(x => x.UserId.Equals(userId))
                .Select(p => p.Post);
            return this;
        }

        public Post GetById(string id)
        {
            return _context.Posts
                .Include(post => post.Category)
                .Include(post => post.User)
                .Include(post => post.PostTags)
                .ThenInclude(postTag => postTag.Tag)
                .FirstOrDefault(post => post.Id == id);
        }

        public void AddTag(Post post, Tag tag)
        {
            if (!Guid.TryParse(tag.Id, out _))
            {
                tag.Name = tag.Id;
                tag.Id = Guid.NewGuid().ToString();
                _context.Tags.Add(tag);
                _context.SaveChanges();
            }

            _context.PostTags.Add(new PostTag
            {
                PostId = post.Id,
                TagId = tag.Id
            });

            _context.SaveChanges();
        }

        public void AddTags(Post post, IEnumerable<Tag> tags)
        {
            foreach (var tag in tags) AddTag(post, tag);
        }

        public PostRepository AddTags(Post post, CreatePostViewModel createPostViewModel)
        {
            AddTags(
                post,
                createPostViewModel.SelectedTagIds.Select(x => new Tag
                {
                    Id = x
                })
            );
            return this;
        }

        public void RemoveTags(Post post)
        {
            _context.PostTags
                .RemoveRange(_context.PostTags
                    .Where(postTag => postTag.PostId.Equals(post.Id))
                );
            _context.SaveChanges();
        }

        public PostRepository Create(CreatePostViewModel createViewModel)
        {
            var post = PostFactory.Model(createViewModel);

            _context.Posts.Add(post);
            _context.SaveChanges();

            AddTags(post, createViewModel);

            return this;
        }

        public PostRepository Update(Post post, CreatePostViewModel createViewModel)
        {
            RemoveTags(post);

            post.CategoryId = createViewModel.CategoryId;
            post.Content = createViewModel.Content;
            post.Subject = createViewModel.Subject;
            post.Timestamp = DateTime.Now;

            _context.SaveChanges();

            AddTags(post, createViewModel);

            return this;
        }

        public PostRepository Update(CreatePostViewModel createViewModel)
        {
            return Update(GetById(createViewModel.Id), createViewModel);
        }


        public PostRepository Delete(Post post)
        {
            RemoveTags(post);
            _context.Posts.Remove(post);
            _context.SaveChanges();
            return this;
        }

        public PostRepository Delete(string id)
        {
            var post = _context.Posts.Find(id);
            return Delete(post);
        }

        public List<Post> ToList()
        {
            return _posts.ToList();
        }
    }
}