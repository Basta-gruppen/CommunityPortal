using System;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommunityPortal.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        [HttpGet]
        [Route("/Posts/")]        
        public IActionResult Index()
        {
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
            return View(
                _context
                    .Posts
                    .Include(post => post.Category)
                    .Include(post => post.User)
                    .Include(post => post.PostTags)
                    .ThenInclude(postTag => postTag.Tag)
                    .Where(p => p.PostTags.Any(l => l.Tag.Name.Equals(tag)))
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
        public IActionResult Create(Post newPost)
        {
            newPost.Id = Guid.NewGuid().ToString();

            if (!ModelState.IsValid) return BadRequest("Model state not valid");
            _context.Posts.Add(newPost);
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