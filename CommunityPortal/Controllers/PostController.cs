using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommunityPortal.Controllers
{
    public class PostController : Controller
    {
        private readonly List<Post> _posts = new List<Post>
        {
            new Post
            {
                User = new ApplicationUser
                {
                    UserName = "Tim"
                },

                Id = Guid.NewGuid().ToString(),
                Subject = "This is a post",
                PostTags = new List<PostTag>
                {
                    new PostTag
                    {
                        TagId = Guid.NewGuid().ToString(),
                        Tag = new Tag
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Foo"
                        }
                    }
                }
            },
            new Post
            {
                Id = Guid.NewGuid().ToString(),
                User = new ApplicationUser
                {
                    UserName = "Martinyas"
                },
                Subject = "Off-Topic",

                PostTags = new List<PostTag>
                {
                    new PostTag
                    {
                        TagId = Guid.NewGuid().ToString(),
                        Tag = new Tag
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Foo"
                        }
                    }
                }
            }
        };

        public IActionResult Index()
        {
            return View(_posts);
        }
        
        [HttpGet]
        [Route("/People/{id:int}")]
        public new IActionResult View(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}