using System.Collections.Generic;
using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;

namespace CommunityPortal.Repositories
{
    public class PostRepository: IRepository<Post, CreatePostViewModel>
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IRepository<Post, CreatePostViewModel> Create(CreatePostViewModel createViewModel)
        {
            var newPost = new Post
            {
                Subject = createViewModel.Subject,
                Category = _context.Categories.Find(createViewModel.CategoryId),
                Content = createViewModel.Content
            };

            _context.Posts.Add(newPost);
            _context.SaveChanges();

            foreach (var tagId in createViewModel.Tags)
                _context.PostTags.Add(new PostTag
                {
                    PostId = newPost.Id,
                    TagId = tagId
                });
            _context.SaveChanges();
            return this;
        }

        public IRepository<Post, CreatePostViewModel> Delete(Post model)
        {
            throw new System.NotImplementedException();
        }

        public IRepository<Post, CreatePostViewModel> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Post> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Post GetByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}