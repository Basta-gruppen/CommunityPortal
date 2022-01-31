using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace CommunityPortal.Controllers
{
    [Authorize]
    public class GroupController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        
        public GroupController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _context = applicationDbContext;
            _userManager = userManager;
        }
        
        // View all groups user is in
        public IActionResult Index()
        {
            string userId = _userManager.GetUserId(this.User);
            List<Group> groups = _context.UserGroups
                .Where(userGroup => userGroup.UserId == userId)
                .Include(userGroup => userGroup.Group)
                .Select(userGroup => userGroup.Group)
                .ToList();

            GroupViewModel groupViewModel = new GroupViewModel()
            {
                Groups = groups
            };

            return View(groupViewModel);
        }

        public IActionResult Details(string id)
        {
            Group group = _context.Groups.Find(id);

            if (group != null)
            {
                List<ApplicationUser> members = _context.UserGroups
                    .Include(ug => ug.User)
                    .Where(ug => ug.GroupId == id)
                    .Select(ug => ug.User)
                    .ToList();

                ApplicationUser owner = _context.Users.Find(group.OwnerId);

                GroupDetailsViewModel groupDetails = new GroupDetailsViewModel()
                {
                    Group = group,
                    Members = members,
                    Owner = owner,
                    IsOwner = owner.Id == _userManager.GetUserId(this.User)
                };
                
                return View(groupDetails);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Group newGroup)
        {
            //Check if group with name already exists
            if (_context.Groups.Any(group => string.Equals(newGroup.Name, group.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return BadRequest("Group with that name already exists");
            }
            
            string userId = _userManager.GetUserId(this.User);
            
            newGroup.Id = Guid.NewGuid().ToString();
            newGroup.OwnerId = userId;
            ModelState.Remove("newGroup.OwnerId");

            if (ModelState.IsValid)
            {
                _context.Groups.Add(newGroup);
                _context.UserGroups.Add(new UserGroup()
                {
                    GroupId = newGroup.Id,
                    UserId = userId
                });

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

            return BadRequest("Model state not valid");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Invalid id");

            Group group = _context.Groups.Find(id);

            if (group != null)
            {
                if (IsUserGroupOwner(_userManager.GetUserId(this.User), group))
                {
                    _context.Groups.Remove(group);

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

                return Unauthorized();
            }

            return BadRequest("Could not find group with id " + id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMember(string groupId, string userId)
        {
            Group group = _context.Groups.Find(groupId);

            if (group == null)
                return BadRequest("Group not found, id submitted: " + groupId);

            if (IsUserGroupOwner(_userManager.GetUserId(this.User), group))
            {
                _context.UserGroups.Add(new UserGroup()
                {
                    UserId = userId,
                    GroupId = groupId
                });

                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }

                return RedirectToAction(nameof(Details), new {id = groupId});
            }

            return Unauthorized();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult KickMember(string groupId, string userId)
        {
            Group group = _context.Groups.Find(groupId);

            if (group == null)
                return BadRequest("Group not found, id submitted: " + groupId);

            if (IsUserGroupOwner(userId, group) && group.OwnerId != userId)
            {
                UserGroup userGroup = _context.UserGroups.First(ug => ug.GroupId == groupId && ug.UserId == userId);
                _context.UserGroups.Remove(userGroup);

                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }

                return RedirectToAction(nameof(Details), new {id = groupId});
            }

            return Unauthorized();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LeaveGroup(string groupId)
        {
            if (!_context.Groups.Any(g => g.Id == groupId))
                return BadRequest("Group not found, id submitted: " + groupId);

            string currentUserId = _userManager.GetUserId(this.User);
            
            if (IsUserGroupMember(currentUserId, groupId, _context.UserGroups))
            {
                UserGroup userGroup = _context.UserGroups.First(ug => ug.GroupId == groupId && ug.UserId == currentUserId);
                _context.UserGroups.Remove(userGroup);

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

            return Unauthorized();
        }

        public static bool IsUserGroupMember(string userId, string groupId, IEnumerable<UserGroup> userGroups)
        {
            bool isMember = userGroups
                .Where(ug => ug.GroupId == groupId)
                .Any(ug => ug.UserId == userId);

            return isMember;
        }

        public static bool IsUserGroupOwner(string userId, Group group)
        {
            return group.OwnerId == userId;
        }
    }
}