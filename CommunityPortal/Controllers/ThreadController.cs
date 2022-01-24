using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
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

            if (thread == null)
            {
                return NotFound();
            }
            
            thread.Replies = thread.Replies.OrderBy(r => r.TimeStamp).ToList();
            
            return View(thread);
        }

        [HttpGet]
        public IActionResult Create(string subForumId)
        {
            CreateThreadViewModel createThreadViewModel = new CreateThreadViewModel()
            {
                Thread = new Thread()
                {
                    SubForum = _context.SubForums.Find(subForumId)
                }
            };

            return View(createThreadViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateThreadViewModel createThreadViewModel)
        {
            // TODO: Remove line below because user needs to be logged in to create
            string posterId = _context.Users.ToList()[0].Id;
            
            DateTime timestamp = DateTime.Now;

            createThreadViewModel.Thread.UserId = posterId;
            ModelState.Remove("Thread.UserId"); // Remove state since we are setting it manually
            
            createThreadViewModel.Thread.Id = Guid.NewGuid().ToString();
            createThreadViewModel.Thread.TimeStamp = timestamp;
            
            createThreadViewModel.Reply.UserId = posterId;
            ModelState.Remove("Reply.UserId"); // Remove state since we are setting it manually
            
            createThreadViewModel.Reply.Id = Guid.NewGuid().ToString();
            createThreadViewModel.Reply.ThreadId = createThreadViewModel.Thread.Id;
            ModelState.Remove("Reply.ThreadId"); // Remove state since we are setting it manually
            
            createThreadViewModel.Reply.TimeStamp = timestamp;

            if (ModelState.IsValid)
            {
                _context.Threads.Add(createThreadViewModel.Thread);
                _context.Replies.Add(createThreadViewModel.Reply);
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }

                return RedirectToAction(nameof(Index), new { id = createThreadViewModel.Thread.Id });
            }
            
            return BadRequest("Model state not valid");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

            return RedirectToAction(nameof(SubForumController.Details), nameof(SubForum), new { id = thread.SubForumId });
        }
    }
}