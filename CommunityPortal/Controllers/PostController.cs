using System;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        //TODO: Add functionality to Add tags
        public IActionResult Create(CreatePostViewModel createViewModel)
        {
            var newPost = new Post
            {
                Id = Guid.NewGuid().ToString(),
                UserId = _userManager.GetUserId(User),
                Subject = createViewModel.Subject,
                CategoryId = createViewModel.CategoryId,
                Content = createViewModel.Content,
                Timestamp = new DateTime()
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
            return RedirectToAction(nameof(Index));
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