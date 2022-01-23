using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace CommunityPortal.Controllers
{
    [Route("rss")]
    [Produces("application/xml")]
    public class FeedController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly PostRepository _postRepository;

        public FeedController(PostRepository postRepository,
            ApplicationDbContext context)
        {
            _postRepository = postRepository;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(string categories = null)
        {
            var rss = new Rss
            {
                Version = "2.0",
                Channel = new RssChannel
                {
                    Title = "Posts - CommunityPortal",
                    Link = "Demo",
                    Language = "en-US",
                    Items = new List<RssChannelItem>()
                }
            };

            var categoryNames = string.IsNullOrEmpty(categories)
                ? _context.Categories.Select(category => category.Name)
                : _context.Categories.Select(category => category.Name)
                    .Where(categoryName => categories
                        .Split(",", StringSplitOptions.RemoveEmptyEntries)
                        .Select(HttpUtility.UrlDecode)
                        .Contains(categoryName));

            rss.Channel.Description =
                $"Posts for categories {categoryNames.OrderBy(categoryName => categoryName).Join()}";

            foreach (var rssItem in _postRepository
                         .GetAll()
                         .ByCategoryNames(categoryNames.ToArray())
                         .ToList()
                         .Select(
                             post => new RssChannelItem
                             {
                                 Category = post.Category.Name,
                                 Guid = post.Id,
                                 Title = post.Subject,
                                 Description = Regex.Replace(post.Content, "<.*?>", string.Empty),
                                 Link = Url.Action(
                                     "View",
                                     "Post",
                                     new
                                     {
                                         post.Id
                                     }
                                 ),
                                 PublicationDate = post.Timestamp,
                                 Author = post.User.UserName
                             }))
                rss.Channel.Items.Add(rssItem);
            return Ok(rss);
        }
    }
}