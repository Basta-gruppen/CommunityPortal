using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CommunityPortal.Controllers
{
    [Authorize]
    public class ThreadController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ThreadController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _context = applicationDbContext;
            _userManager = userManager;
        }
        
        public IActionResult Index(string id)
        {
            Thread thread = _context.Threads
                .Include(t => t.User)
                .Include(t => t.Replies).ThenInclude(r => r.User)
                .Include(t => t.Replies).ThenInclude(r => r.Quote)
                .Include(t => t.SubForum).ThenInclude(sf => sf.SubForumGroups)
                .Include(t => t.SubForum).ThenInclude(sf => sf.Forum)
                .FirstOrDefault(t => t.Id == id);

            if (thread == null)
                return NotFound();
            
            string currentUserId = _userManager.GetUserId(this.User);

            List<UserGroup> userGroups = _context.UserGroups.Where(ug => ug.UserId == currentUserId).ToList();
            
            if (UserController.UserOwnsSubForum(thread.SubForum, currentUserId) ||
                UserController.UserInSubForumGroup(thread.SubForum.SubForumGroups, userGroups))
            {
                thread.Replies = thread.Replies.OrderBy(r => r.TimeStamp).ToList();

                ThreadViewModel threadViewModel = new ThreadViewModel()
                {
                    Thread = thread,
                    IsOwner = thread.UserId == currentUserId
                };
                
                return View(threadViewModel);
            }

            return Unauthorized();
        }

        [HttpGet]
        public IActionResult Create(string subForumId)
        {
            SubForum subForum = _context.SubForums
                .Include(sf => sf.SubForumGroups)
                .FirstOrDefault(sf => sf.Id == subForumId);

            if (subForum == null)
                return NotFound();

            string currentUserId = _userManager.GetUserId(this.User);

            List<UserGroup> userGroups = _context.UserGroups.Where(ug => ug.UserId == currentUserId).ToList();
            
            if (UserController.UserOwnsSubForum(subForum, currentUserId) ||
                UserController.UserInSubForumGroup(subForum.SubForumGroups, userGroups))
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

            return Unauthorized();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateThreadViewModel createThreadViewModel)
        {
            SubForum subForum = _context.SubForums
                .Include(sf => sf.SubForumGroups)
                .FirstOrDefault(sf => sf.Id == createThreadViewModel.Thread.SubForumId);

            if (subForum == null)
                return BadRequest("SubForum does not exist");
            
            string currentUserId = _userManager.GetUserId(this.User);

            List<UserGroup> userGroups = _context.UserGroups.Where(ug => ug.UserId == currentUserId).ToList();
            
            if (UserController.UserOwnsSubForum(subForum, currentUserId) ||
                UserController.UserInSubForumGroup(subForum.SubForumGroups, userGroups))
            {
                DateTime timestamp = DateTime.Now;

                createThreadViewModel.Thread.UserId = currentUserId;
                ModelState.Remove("Thread.UserId"); // Remove state since we are setting it manually

                createThreadViewModel.Thread.Id = Guid.NewGuid().ToString();
                createThreadViewModel.Thread.TimeStamp = timestamp;

                createThreadViewModel.Reply.UserId = currentUserId;
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

                    return RedirectToAction(nameof(Index), new {id = createThreadViewModel.Thread.Id});
                }

                return BadRequest("Model state not valid");
            }
            
            return Unauthorized();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {
            Thread thread = _context.Threads.Find(id);

            if (thread == null)
                return NotFound();
            
            SubForum subForum = _context.SubForums
                .Include(sf => sf.SubForumGroups)
                .FirstOrDefault(sf => sf.Id == thread.SubForumId);

            if (subForum == null)
                return NotFound();

            string currentUserId = _userManager.GetUserId(this.User);

            List<UserGroup> userGroups = _context.UserGroups.Where(ug => ug.UserId == currentUserId).ToList();
            
            if (UserController.UserOwnsSubForum(subForum, currentUserId) ||
                UserController.UserInSubForumGroup(subForum.SubForumGroups, userGroups) &&
                thread.UserId == currentUserId)
            {
                _context.Threads.Remove(thread);

                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }

                return RedirectToAction(nameof(SubForumController.Details), nameof(SubForum),
                    new {id = thread.SubForumId});
            }

            return Unauthorized();
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            Thread thread = _context.Threads.Find(id);

            if (thread == null)
                return NotFound();
            
            SubForum subForum = _context.SubForums
                .Include(sf => sf.SubForumGroups)
                .FirstOrDefault(sf => sf.Id == thread.SubForumId);

            if (subForum == null)
                return NotFound();

            string currentUserId = _userManager.GetUserId(this.User);

            List<UserGroup> userGroups = _context.UserGroups.Where(ug => ug.UserId == currentUserId).ToList();

            if (UserController.UserOwnsSubForum(subForum, currentUserId) ||
                UserController.UserInSubForumGroup(subForum.SubForumGroups, userGroups) &&
                thread.UserId == currentUserId)
            {
                Reply reply = _context.Replies
                    .Where(r => r.ThreadId == thread.Id)
                    .OrderBy(r => r.TimeStamp).First();

                ThreadUpdateViewModel threadUpdateViewModel = new ThreadUpdateViewModel()
                {
                    ThreadId = thread.Id,
                    Subject = thread.Subject,
                    Content = reply.Content
                };

                return View(threadUpdateViewModel);
            }

            return Unauthorized();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ThreadUpdateViewModel threadViewModel)
        {
            Thread thread = _context.Threads.Find(threadViewModel.ThreadId);
            if (thread == null)
                return NotFound();
            
            SubForum subForum = _context.SubForums
                .Include(sf => sf.SubForumGroups)
                .FirstOrDefault(sf => sf.Id == thread.SubForumId);
            if (subForum == null)
                return NotFound();
            
            string currentUserId = _userManager.GetUserId(this.User);
            List<UserGroup> userGroups = _context.UserGroups.Where(ug => ug.UserId == currentUserId).ToList();
            
            if (UserController.UserOwnsSubForum(subForum, currentUserId) ||
                UserController.UserInSubForumGroup(subForum.SubForumGroups, userGroups) &&
                thread.UserId == currentUserId)
            {
                Reply reply = _context.Replies
                    .Where(r => r.ThreadId == thread.Id)
                    .OrderBy(r => r.TimeStamp).First();

                thread.Subject = threadViewModel.Subject;
                reply.Content = threadViewModel.Content;

                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }

                return RedirectToAction(nameof(Index), new {id = threadViewModel.ThreadId});
            }

            return Unauthorized();
        }
    }
}