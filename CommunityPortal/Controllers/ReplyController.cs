using System;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Thread = System.Threading.Thread;

namespace CommunityPortal.Controllers
{
    public class ReplyController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public ReplyController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        
        // GET
        public IActionResult Index()
        {
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Reply newReply)
        {
            // TODO: Remove this with posted user
            newReply.UserId = _context.Users.ToList()[0].Id;
            
            newReply.Id = Guid.NewGuid().ToString();
            newReply.TimeStamp = DateTime.Now;
            
            ModelState.Remove("UserId");

            if (ModelState.IsValid)
            {
                _context.Replies.Add(newReply);

                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }

                return RedirectToAction(nameof(Index), nameof(Thread), new {id = newReply.ThreadId});
            }

            return BadRequest("Model state is not valid");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest("Invalid reply id");
            }
            
            Reply reply = _context.Replies.Find(id);
            _context.Replies.Remove(reply);

            return RedirectToAction(nameof(Index), nameof(Thread), new { id = reply.ThreadId });
        }
    }
}