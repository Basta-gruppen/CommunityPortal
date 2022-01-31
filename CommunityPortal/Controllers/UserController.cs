using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using CommunityPortal.Data;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace CommunityPortal.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
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