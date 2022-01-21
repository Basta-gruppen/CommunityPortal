using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Factories;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace CommunityPortal.Repositories
{
    public class PostRepository
    {
        private readonly ApplicationDbContext _context;
        private IEnumerable<Post> _posts;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public PostRepository GetAll()
        {
           _posts = _context
                .Posts
                .Include(post => post.Category)
                .Include(post => post.User)
                .Include(post => post.PostTags)
                .ThenInclude(postTag => postTag.Tag)
                .OrderByDescending(x => x.Timestamp);
           return this;
        }

        public IEnumerable<Post> ByTag(string tag)
        {
            return _posts
                .Where(
                    post => post.PostTags.Any(postTag => postTag.Tag.Name.Equals(tag))
                );
        }
        
        public IEnumerable<Post> ByCategoryName(string category)
        {
            return _posts
            .Where(
                    post => post.Category.Name.Equals(category)
                );
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
            foreach (var tag in tags)
            {
                AddTag(post, tag);
            }
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
            var post = PostFactory.Create(createViewModel);

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
            return Update(post: GetById(createViewModel.Id), createViewModel);
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