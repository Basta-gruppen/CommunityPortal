using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CommunityPortal.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PostController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _context = applicationDbContext;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("/Posts/")]
        public IActionResult Index()
        {
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View(
                _context
                    .Posts
                    .Include(post => post.Category)
                    .Include(post => post.User)
                    .Include(post => post.PostTags)
                    .ThenInclude(postTag => postTag.Tag)
                    .ToList());
        }

        [HttpGet]
        [Route("/Posts/tag/{Tag}")]
        public IActionResult Index(string tag)
        {
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View(
                _context
                    .Posts
                    .Include(post => post.Category)
                    .Include(post => post.User)
                    .Include(post => post.PostTags)
                    .ThenInclude(postTag => postTag.Tag)
                    .Where(post => post.PostTags.Any(postTag => postTag.Tag.Name.Equals(tag)))
                    .ToList());
        }

        [HttpGet]
        [Route("/Post/{id}")]
        public new IActionResult View(string id)
        {
            var post = _context.Posts
                .Include(post => post.Category)
                .Include(post => post.User)
                .Include(post => post.PostTags)
                .ThenInclude(postTag => postTag.Tag)
                .FirstOrDefault(post => post.Id == id);
            if (post == null) return NotFound();
            return View(post);
        }
        
        public IActionResult Create()
        {
//            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        private void AddTagsToPost(Post post, IEnumerable<Tag> tags)
        {
            foreach (var newTag in tags)
            {
                _context.Tags.Add(newTag);
                _context.SaveChanges();
                _context.PostTags.Add(new PostTag
                {
                    PostId = post.Id,
                    TagId = newTag.Id
                });
                _context.SaveChanges();
            }            
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreatePostViewModel createViewModel)
        {
            var newPost = new Post
            {
                Id = createViewModel.Id?? Guid.NewGuid().ToString(),
                UserId = _userManager.GetUserId(User),
                Subject = createViewModel.Subject,
                CategoryId = createViewModel.CategoryId,
                Content = createViewModel.Content,
                Timestamp = DateTime.Now,
            };

            _context.Posts.Add(newPost);
            _context.SaveChanges();

            if (!string.IsNullOrEmpty(createViewModel.Tags))
            {
                var tags = (JsonConvert
                    .DeserializeObject<List<TagViewModel>>(createViewModel.Tags)
                    .Select(tag => new Tag
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = tag.value
                    }));

                AddTagsToPost(newPost, tags);
            }

            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var createPostViewModel = new CreatePostViewModel();
            ViewBag.Categories = _context.Categories.ToList();
            var post = _context.Posts
                .Include(post => post.Category)
                .Include(post => post.User)
                .Include(post => post.PostTags)
                .ThenInclude(postTag => postTag.Tag)
                .FirstOrDefault(post => post.Id == id);

            if (post != null)
            {
                createPostViewModel = new CreatePostViewModel
                {
                    Id = post.Id,
                    UserId = _userManager.GetUserId(User),
                    Subject = post.Subject,
                    CategoryId = post.CategoryId,
                    Content = post.Content,
                };
            }
            return View(createPostViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {
            var post = _context.Posts.Find(id);
            _context.Posts.Remove(post);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                return BadRequest(e.Message);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}