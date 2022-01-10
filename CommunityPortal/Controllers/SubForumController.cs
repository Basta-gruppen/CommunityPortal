using System;
using System.Collections.Generic;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommunityPortal.Controllers
{
    public class SubForumController : Controller
    {
        // GET
        public IActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }
            
            SubForum subForum = new SubForum()
            {
                Name = "Dummy SubForum",
                Threads = new List<Thread>()
                {
                    new Thread()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Subject = "My first thread!",
                        User = new ApplicationUser()
                        {
                            UserName = "Martynas"
                        },
                        TimeStamp = DateTime.Now
                    },
                    new Thread()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Subject = "My second thread!",
                        User = new ApplicationUser()
                        {
                            UserName = "Tim"
                        },
                        TimeStamp = DateTime.Now
                    },
                    new Thread()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Subject = "My third thread!",
                        User = new ApplicationUser()
                        {
                            UserName = "Monika"
                        },
                        TimeStamp = DateTime.Now
                    },
                    new Thread()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Subject = "My fourth thread!",
                        User = new ApplicationUser()
                        {
                            UserName = "Ekram"
                        },
                        TimeStamp = DateTime.Now
                    }
                }
            };
            
            return View(subForum);
        }
    }
}