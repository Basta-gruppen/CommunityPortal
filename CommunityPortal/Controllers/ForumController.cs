using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    public class ForumController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ForumController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _context = applicationDbContext;
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            string currentUserId = _userManager.GetUserId(this.User);

            List<Forum> forums = _context.Forums.ToList();
            
            List<string> usersGroupIds = _context.UserGroups
                .Where(ug => ug.UserId == currentUserId)
                .Select(ug => ug.GroupId)
                .ToList();

            List<SubForum> subForums = _context.SubForums
                .Include(sf => sf.SubForumGroups)
                .Where(sf => sf.OwnerId == currentUserId || sf.SubForumGroups.Any(sfg => usersGroupIds.Contains(sfg.GroupId)))
                .ToList();

            foreach (Forum forum in forums)
            {
                forum.SubForums = subForums.Where(sf => sf.ForumId == forum.Id).ToList();
            }

            return View(forums);
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            Forum forum = _context.Forums.Find(id);
            
            if (forum == null)
            {
                return NotFound();
            }
            
            string currentUserId = _userManager.GetUserId(this.User);
            
            List<string> usersGroupIds = _context.UserGroups
                .Where(ug => ug.UserId == currentUserId)
                .Select(ug => ug.GroupId)
                .ToList();

            forum.SubForums = _context.SubForums
                .Where(sf => sf.ForumId == forum.Id)
                .Include(sf => sf.SubForumGroups)
                .Where(sf => sf.OwnerId == currentUserId || sf.SubForumGroups.Any(sfg => usersGroupIds.Contains(sfg.GroupId)))
                .ToList();

            return View(forum);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Forum newForum)
        {
            if (_context.Forums.Any(f => f.Name == newForum.Name))
                return BadRequest("Forum with that name already exists");
            
            newForum.Id = Guid.NewGuid().ToString();

            if (ModelState.IsValid)
            {
                _context.Forums.Add(newForum);
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
            Forum forum = _context.Forums.Find(id);
            _context.Forums.Remove(forum);
            
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Forum editedForum)
        {
            if (ModelState.IsValid)
            {
                _context.Forums.Find(editedForum.Id).Name = editedForum.Name;

                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    return BadRequest(e.Message);
                }

                return RedirectToAction(nameof(Details), new {id = editedForum.Id});
            }

            return BadRequest("Model state not valid");
        }
    }
}