using System;
using System.Collections.Generic;
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
            List<Forum> forums = new List<Forum>()
            {
                new Forum()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Introductions",
                    SubForums = new List<SubForum>()
                    {
                        new SubForum()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "New People",
                            Description = "New people can post their introductions here."
                        },
                        new SubForum()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Veterans",
                            Description = "Veterans can introduce themselves here."
                        }
                    }
                },
                new Forum()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Off-Topic",
                    SubForums = new List<SubForum>()
                    {
                        new SubForum()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Gaming",
                            Description = "Threads about gaming."
                        },
                        new SubForum()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Health & Safety",
                            Description = "Discussions regarding people's health & safety."
                        }
                    }
                }
            };
            
            forums.AddRange(_context.Forums.Include(f => f.SubForums));

            return View(forums);
        }

        public IActionResult Create(Forum newForum)
        {
            //TODO: Check if forum with name already exists
            
            newForum.Id = Guid.NewGuid().ToString();

            if (ModelState.IsValid)
            {
                _context.Add(newForum);
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
            
            return BadRequest();
        }
        
        
    }
}