﻿using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.Repositories;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CommunityPortal.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PostController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _context = applicationDbContext;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("/Posts/")]
        public IActionResult Index()
        {
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View(
                _context
                    .Posts
                    .Include(post => post.Category)
                    .Include(post => post.User)
                    .Include(post => post.PostTags)
                    .ThenInclude(postTag => postTag.Tag)
                    .OrderByDescending(x => x.Timestamp)
                    .ToList());
        }

        [HttpGet]
        [Route("/Posts/tag/{Tag}")]
        public IActionResult Index(string tag)
        {
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View(
                _context
                    .Posts
                    .Include(post => post.Category)
                    .Include(post => post.User)
                    .Include(post => post.PostTags)
                    .ThenInclude(postTag => postTag.Tag)
                    .Where(post => post.PostTags.Any(postTag => postTag.Tag.Name.Equals(tag)))
                    .ToList());
        }

        [HttpGet]
        [Route("/Post/{id}")]
        public new IActionResult View(string id)
        {
            var post = _context.Posts
                .Include(post => post.Category)
                .Include(post => post.User)
                .Include(post => post.PostTags)
                .ThenInclude(postTag => postTag.Tag)
                .FirstOrDefault(post => post.Id == id);
            if (post == null) return NotFound();
            return View(post);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreatePostViewModel createViewModel)
        {
            var newPost = new Post
            {
                Id = Guid.NewGuid().ToString(),
                UserId = _userManager.GetUserId(User),
                Subject = createViewModel.Subject,
                CategoryId = createViewModel.CategoryId,
                Content = createViewModel.Content,
                Timestamp = DateTime.Now
            };

            _context.Posts.Add(newPost);
            _context.SaveChanges();
            

            foreach (var selectedTagId in createViewModel.SelectedTagIds)
            {
                var tagId = selectedTagId;
                if (!Guid.TryParse(tagId, out _))
                {
                    var tag = new Tag
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = selectedTagId
                    };
                    _context.Tags.Add(tag);
                    _context.SaveChanges();
                    tagId = tag.Id;
                }

                _context.PostTags.Add(new PostTag
                {
                    PostId = newPost.Id,
                    TagId = tagId
                });

                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CreatePostViewModel createViewModel)
        {
            var post = _context.Posts.First(post => post.Id == createViewModel.Id);

            _context.PostTags
                .RemoveRange(_context.PostTags
                    .Where(postTag => postTag.PostId.Equals(createViewModel.Id))
                );
            _context.SaveChanges();


            post.CategoryId = createViewModel.CategoryId;
            post.Content = createViewModel.Content;
            post.Subject = createViewModel.Subject;
            post.Timestamp = DateTime.Now;

            _context.SaveChanges();
            
            foreach (var selectedTagId in createViewModel.SelectedTagIds)
            {
                var tagId = selectedTagId;
                if (!Guid.TryParse(selectedTagId, out _))
                {
                    var tag = new Tag
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = selectedTagId
                    };
                    _context.Tags.Add(tag);
                    _context.SaveChanges();
                    tagId = tag.Id;
                }

                _context.PostTags.Add(new PostTag
                {
                    PostId = post.Id,
                    TagId = tagId
                });

                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var createPostViewModel = new CreatePostViewModel();
            ViewBag.Categories = _context.Categories.ToList();
            var post = _context.Posts
                .Include(post => post.Category)
                .Include(post => post.User)
                .Include(post => post.PostTags)
                .ThenInclude(postTag => postTag.Tag)
                .FirstOrDefault(post => post.Id == id);

            if (post == null) return View(createPostViewModel);
            createPostViewModel = new CreatePostViewModel
            {
                Id = post.Id,
                UserId = _userManager.GetUserId(User),
                Subject = post.Subject,
                CategoryId = post.CategoryId,
                Content = post.Content,
                SelectedTagIds = post.PostTags.Select(x => x.TagId).ToArray(),
            };
            createPostViewModel.TagList
                .AddRange(
                    post.PostTags.Select(
                        x => new SelectListItem(x.Tag.Name, x.Tag.Id)
                    )
                );

            return View(createPostViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {
            var post = _context.Posts.Find(id);
            _context.Posts.Remove(post);

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