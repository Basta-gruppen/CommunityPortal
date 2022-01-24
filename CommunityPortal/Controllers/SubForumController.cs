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
    public class SubForumController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubForumController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        
        public IActionResult Details(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            SubForum subForum = _context.SubForums
                .Include(sf => sf.Threads)
                .ThenInclude(t => t.User)
                .Include(sf => sf.Forum)
                .FirstOrDefault(sf => sf.Id == id);

            if (subForum != null)
            {
                subForum.Threads = subForum.Threads.OrderByDescending(t => t.TimeStamp).ToList();
            }
            
            return View(subForum);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SubForum newSubForum)
        {
            if (_context.SubForums.Any(sf => sf.Name == newSubForum.Name))
                return BadRequest("Sub Forum with that name already exists");
            
            newSubForum.Id = Guid.NewGuid().ToString();

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
            SubForum subForum = _context.SubForums.Find(id);

            if (subForum != null)
            {
                EditSubForumViewModel viewModel = new EditSubForumViewModel()
                {
                    SubForum = subForum,
                    Forums = _context.Forums.ToList()
                };

                return View(viewModel);
            }

            return NotFound("Could not find SubForum with id " + id);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(EditSubForumViewModel editSubForumViewModel)
        {
            if (ModelState.IsValid)
            {
                SubForum subForum = _context.SubForums.Find(editSubForumViewModel.SubForum.Id);

                if (subForum != null)
                {
                    subForum.Name = editSubForumViewModel.SubForum.Name;
                    subForum.Description = editSubForumViewModel.SubForum.Description;
                    subForum.ForumId = editSubForumViewModel.SubForum.ForumId;
                    
                    try
                    {
                        _context.SaveChanges();
                    }
                    catch (DbUpdateException e)
                    {
                        return BadRequest(e.Message);
                    }
                    
                    return RedirectToAction(nameof(Details), new {id = editSubForumViewModel.SubForum.Id});
                }

                return NotFound($"SubForum with id {editSubForumViewModel.SubForum.Id} not found.");
            }
            return BadRequest("Model state not valid");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Invalid ID");
            
            SubForum subForum = _context.SubForums.Find(id);
            
            if (subForum != null)
            {
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

            return NotFound($"SubForum with id {id} not found.");
        }
    }
}