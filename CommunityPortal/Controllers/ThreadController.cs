using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommunityPortal.Controllers
{
    public class ThreadController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThreadController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        
        public IActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            Thread thread = _context.Threads
                .Include(t => t.User)
                .Include(t => t.Replies)
                .ThenInclude(r => r.User)
                .FirstOrDefault(t => t.Id == id);

            thread.Replies = thread.Replies.OrderBy(r => r.TimeStamp).ToList();
            
            return View(thread);
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            Thread thread = _context.Threads.Find(id);
            _context.Threads.Remove(thread);
            
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