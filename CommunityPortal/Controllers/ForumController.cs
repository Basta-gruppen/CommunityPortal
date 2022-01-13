using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommunityPortal.Controllers
{
    public class ForumController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public ForumController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        
        public IActionResult Index(string status)
        {
            List<Forum> forums = _context.Forums.Include(f => f.SubForums).ToList();

            return View(forums);
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
    }
}