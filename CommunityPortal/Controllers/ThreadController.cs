using System;
using System.Collections.Generic;
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

            ApplicationUser poster = new ApplicationUser()
            {
                UserName = "DummyUser",
                ImageURL = "https://i.pravatar.cc/100?img=1"
            };
            
            Thread thread = new Thread()
            {
                Id = Guid.NewGuid().ToString(),
                Subject = "Dummy Subject for this thread",
                User = poster,
                TimeStamp = DateTime.Now,
                Replies = new List<Reply>()
                {
                    new Reply()
                    {
                        User = poster,
                        TimeStamp = DateTime.Now,
                        Content = "Hello, so this should be the first reply, a.k.a the content of the thread"
                    },
                    new Reply()
                    {
                        User = new ApplicationUser()
                        {
                            UserName = "ReplyingUser1",
                            ImageURL = "https://i.pravatar.cc/100?img=2"
                        },
                        TimeStamp = DateTime.Now,
                        Content = "This should be the first reply to the thread, let's hope it works!"
                    },
                    new Reply()
                    {
                        User = new ApplicationUser()
                        {
                            UserName = "ReplyingUser2",
                            ImageURL = "https://i.pravatar.cc/100?img=3"
                        },
                        TimeStamp = DateTime.Now,
                        Content = "This should be the second reply to the thread!"
                    }
                }
            };
            
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