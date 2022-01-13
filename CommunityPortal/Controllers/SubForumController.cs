using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommunityPortal.Controllers
{
    public class SubForumController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubForumController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        
        public IActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            SubForum subForum = _context.SubForums
                .Include(sf => sf.Threads)
                .ThenInclude(t => t.User)
                .Include(sf => sf.Forum)
                .FirstOrDefault(sf => sf.Id == id);

            if (subForum != null)
            {
                subForum.Threads = subForum.Threads.OrderByDescending(t => t.TimeStamp).ToList();
            }
            
            return View(subForum);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SubForum newSubForum)
        {
            if (_context.SubForums.Any(sf => sf.Name == newSubForum.Name))
                return BadRequest("Sub Forum with that name already exists");
            
            newSubForum.Id = Guid.NewGuid().ToString();

            if (ModelState.IsValid)
            {
                _context.SubForums.Add(newSubForum);
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }

                return RedirectToAction(nameof(ForumController.Details), nameof(Forum), new { id = newSubForum.ForumId});
            }
            
            return BadRequest("Model state is not valid");
        }
    }
}