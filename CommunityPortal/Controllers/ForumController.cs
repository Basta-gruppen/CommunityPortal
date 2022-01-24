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
        
        public IActionResult Index()
        {
            List<Forum> forums = _context.Forums.Include(f => f.SubForums).ToList();

            return View(forums);
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            Forum forum = _context.Forums
                .Include(f => f.SubForums)
                .FirstOrDefault(f => f.Id == id);

            if (forum == null)
            {
                return NotFound();
            }

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