using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
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
        
        // GET
        public IActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            SubForum subForum = _context.SubForums
                .Include(sf => sf.Threads)
                .ThenInclude(t => t.User)
                .FirstOrDefault(sf => sf.Id == id);

            subForum.Threads = subForum.Threads.OrderByDescending(t => t.TimeStamp).ToList();

            return View(subForum);
        }
    }
}