using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CommunityPortal.Controllers
{
    public class TagController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TagController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        [HttpGet]
        public IActionResult Get(string query) =>
            new JsonResult(
                _context.Tags
                    .Where(x => x.Name.StartsWith(query))
                    .Select(x => new
                {
                    value = x.Id,
                    label = x.Name
                }),
                new JsonSerializerOptions
                {
                    PropertyNamingPolicy = null
                });
    }
}