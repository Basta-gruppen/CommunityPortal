using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CommunityPortal.Data;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ContentResult = Microsoft.AspNetCore.Mvc.ContentResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;

namespace CommunityPortal.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public UserController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _context = applicationDbContext;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            List<ApplicationUser> users = _context.Users.ToList();

            ApplicationUser adminUser = users.Find(u => u.Id == _userManager.GetUserId(this.User));
            
            users.Remove(adminUser);
            
            return View(users);
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            string userIdToDisplay;
            
            // If ID is empty, display current user's profile
            if (string.IsNullOrWhiteSpace(id))
            {
                userIdToDisplay = _userManager.GetUserId(this.User);
            }
            else
            {
                userIdToDisplay = id;
            }
            
            ApplicationUser user = _context.Users
                .Include(u => u.Posts)
                .Include(u => u.Events)
                .Include(u => u.Threads)
                .Include(u => u.Replies)
                .FirstOrDefault(u => u.Id == userIdToDisplay);

            if (user != null)
            {
                return View(user);
            }

            return NotFound();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            ApplicationUser user = await _context.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            if (await _userManager.IsInRoleAsync(user, "Admin"))
                return BadRequest("Can't remove admin account");

            List<string> userReplyIds = _context.Replies
                .Where(r => r.UserId == user.Id)
                .Select(r=>r.Id)
                .ToList();

            List<Reply> repliesWhereUserWasQuoted = _context.Replies
                .Where(r => userReplyIds.Contains(r.QuoteId)).
                ToList();

            foreach (Reply quotedReply in repliesWhereUserWasQuoted)
            {
                quotedReply.QuoteId = null;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                return BadRequest(e);
            }
            
            _context.Users.Remove(user);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                return BadRequest(e);
            }
            
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult GetNonMembers(string groupId)
        {
            List<ApplicationUser> members = _context.UserGroups
                .Where(ug => ug.GroupId == groupId)
                .Include(ug => ug.User)
                .Select(ug => ug.User)
                .Distinct()
                .ToList();

            List<ApplicationUser> nonMembers = _context.Users.ToList().Except(members).ToList();


            return new JsonResult(
                nonMembers.Select(u => new
                {
                    value = u.Id.ToString(),
                    label = u.UserName
                }),
                new JsonSerializerOptions
                {
                    PropertyNamingPolicy = null
                });
        }

        public static bool UserInSubForumGroup(List<SubForumGroup> subForumGroups, List<UserGroup> userGroups)
        {
            List<string> subForumGroupIds = subForumGroups.Select(sfg => sfg.GroupId).ToList();
            List<string> userGroupIds = userGroups.Select(ug => ug.GroupId).ToList();

            return userGroupIds.Any(ugId => subForumGroupIds.Contains(ugId));
        }
        
        public static bool UserOwnsSubForum(SubForum subForum, string userId) => subForum.OwnerId == userId;
    }
}