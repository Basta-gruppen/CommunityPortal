using System;
using System.Collections.Generic;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CommunityPortal.Controllers
{
    public class ForumController : Controller
    {
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
                            Description = "Discussions regard people's health & safety."
                        }
                    }
                }
            };

            return View(forums);
        }
        
        
    }
}