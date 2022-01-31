using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommunityPortal.Controllers
{
    [Authorize]
    public class SubForumController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public SubForumController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _context = applicationDbContext;
            _userManager = userManager;
        }
        
        public IActionResult Details(string id)
        {
            SubForum subForum = _context.SubForums
                .Include(sf => sf.SubForumGroups)
                .Include(sf => sf.Threads)
                .ThenInclude(t => t.User)
                .Include(sf => sf.Forum)
                .FirstOrDefault(sf => sf.Id == id);

            if (subForum == null)
                return NotFound();

            string currentUserId = _userManager.GetUserId(this.User);

            List<UserGroup> userGroups = _context.UserGroups.Where(ug => ug.UserId == currentUserId).ToList();

            if (UserController.UserOwnsSubForum(subForum, currentUserId) ||
                UserController.UserInSubForumGroup(subForum.SubForumGroups, userGroups))
            {
                subForum.Threads = subForum.Threads.OrderByDescending(t => t.TimeStamp).ToList();

                SubForumViewModel subForumViewModel = new SubForumViewModel()
                {
                    SubForum = subForum,
                    IsOwner = UserController.UserOwnsSubForum(subForum, currentUserId)
                };
                
                return View(subForumViewModel);
            }
            
            return Unauthorized();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SubForum newSubForum)
        {
            if (_context.SubForums.Any(sf => sf.Name == newSubForum.Name))
                return BadRequest("Sub Forum with that name already exists");
            
            newSubForum.Id = Guid.NewGuid().ToString();
            newSubForum.OwnerId = _userManager.GetUserId(this.User);
            ModelState.Remove("OwnerId");

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
        
        [HttpGet]
        public IActionResult Edit(string id)
        {
            SubForum subForum = _context.SubForums
                .Include(sf => sf.SubForumGroups)
                .FirstOrDefault(sf => sf.Id == id);

            if (subForum == null)
                return NotFound("Could not find SubForum with id " + id);
            
            string currentUserId = _userManager.GetUserId(this.User);

            if (!UserController.UserOwnsSubForum(subForum, currentUserId))
                return Unauthorized();

            EditSubForumViewModel viewModel = new EditSubForumViewModel()
            {
                SubForum = subForum,
                Forums = _context.Forums.ToList(),
                AvailableGroups = _context.Groups.Where(group => group.OwnerId == currentUserId)
            };

            return View(viewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(EditSubForumViewModel editSubForumViewModel)
        {
            SubForum subForum = _context.SubForums
                .Include(sf => sf.SubForumGroups)
                .FirstOrDefault(sf => sf.Id == editSubForumViewModel.SubForum.Id);
            
            if (subForum == null)
                return BadRequest($"SubForum with id {editSubForumViewModel.SubForum.Id} not found.");
            
            if (!UserController.UserOwnsSubForum(subForum, _userManager.GetUserId(this.User)))
                return Unauthorized();

            ModelState.Remove("SubForum.OwnerId");
            if (ModelState.IsValid)
            {
                subForum.Name = editSubForumViewModel.SubForum.Name;
                subForum.Description = editSubForumViewModel.SubForum.Description;
                subForum.ForumId = editSubForumViewModel.SubForum.ForumId;

                List<SubForumGroup> newSubForumGroups = new List<SubForumGroup>();
                foreach (var groupId in editSubForumViewModel.GroupIds)
                {
                    newSubForumGroups.Add(new SubForumGroup()
                    {
                        GroupId = groupId,
                        SubForumId = subForum.Id
                    });
                }

                subForum.SubForumGroups = newSubForumGroups;
                    
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.InnerException.Message);
                }
                    
                return RedirectToAction(nameof(Details), new {id = editSubForumViewModel.SubForum.Id});

            }
            
            return BadRequest("Model state not valid");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {
            SubForum subForum = _context.SubForums.Find(id);

            if (subForum == null)
                return NotFound($"SubForum with id {id} not found.");

            if (!UserController.UserOwnsSubForum(subForum, _userManager.GetUserId(this.User)))
                return Unauthorized();
            
            _context.SubForums.Remove(subForum);
            
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                return BadRequest(e.Message);
            }
            
            return RedirectToAction(nameof(Details), nameof(Forum),new {id = subForum.ForumId});
        }
    }
}