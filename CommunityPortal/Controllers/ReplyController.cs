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
using Thread = System.Threading.Thread;

namespace CommunityPortal.Controllers
{
    [Authorize]
    public class ReplyController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReplyController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _context = applicationDbContext;
            _userManager = userManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Reply newReply)
        {
            string currentUserId = _userManager.GetUserId(this.User);

            SubForum subForum = _context.Threads
                .Include(t => t.SubForum)
                .ThenInclude(sf => sf.SubForumGroups)
                .FirstOrDefault(t => t.Id == newReply.ThreadId)
                ?.SubForum;

            if (subForum == null)
                return NotFound("SubForum does not exist");

            List<UserGroup> userGroups = _context.UserGroups.Where(ug => ug.UserId == currentUserId).ToList();

            if (UserController.UserOwnsSubForum(subForum, currentUserId) ||
                UserController.UserInSubForumGroup(subForum.SubForumGroups, userGroups))
            {
                newReply.UserId = currentUserId;
                ModelState.Remove("UserId");

                newReply.Id = Guid.NewGuid().ToString();
                newReply.TimeStamp = DateTime.Now;

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

            return Unauthorized();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {

            Reply reply = _context.Replies.Find(id);

            if (reply == null)
                return NotFound("Reply not found");

            string currentUserId = _userManager.GetUserId(this.User);
            
            if (reply.UserId == currentUserId)
            {
                _context.Replies.Remove(reply);
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }

                return RedirectToAction(nameof(Index), nameof(Thread), new { id = reply.ThreadId });
            }

            return Unauthorized();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ReplyUpdateViewModel replyUpdateViewModel)
        {
            Reply reply = _context.Replies.Find(replyUpdateViewModel.ReplyId);

            if (reply == null)
                return NotFound("Reply not found");

            string currentUserId = _userManager.GetUserId(this.User);

            if (reply.UserId == currentUserId)
            {
                reply.Content = replyUpdateViewModel.Content;
                // reply.QuoteId = replyUpdateViewModel.QuoteId;

                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }
            }

            return Unauthorized();
        }
    }
}