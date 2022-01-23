using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using CommunityPortal.Models;
using CommunityPortal.Repositories;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace CommunityPortal.TagHelpers
{
    public class RssTagHelper: TagHelper
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly CategoryRepository _categoryRepository;
        private readonly LinkGenerator _linkGenerator;
        private readonly UserManager<ApplicationUser> _userManager;
        
        public RssTagHelper(CategoryRepository categoryRepository, LinkGenerator linkGenerator, UserManager<ApplicationUser> userManager, IHttpContextAccessor accessor)
        {
            _categoryRepository = categoryRepository;
            _linkGenerator = linkGenerator;
            _userManager = userManager;
            _accessor = accessor;
        }
        
        public ClaimsPrincipal GetUser() {
            return _accessor?.HttpContext?.User;
        }
        private string GeneratedUrl()
        {
            var user = GetUser();
            if (!user.Identity.IsAuthenticated)
                return _linkGenerator.GetPathByAction(
                    action: "Index",
                    controller: "Feed"
                );
            var userId = _userManager.GetUserId(GetUser());
            return _linkGenerator.GetPathByAction(
                action: "Index",
                controller: "Feed",
                values: new
                {
                    categories = string.Join(",", _categoryRepository
                        .GetAllAsViewModelList(userId)
                        .GetUserSubscribed(userId)
                        .ToList()
                        .Select(x => x.Name)
                    )
                }
            );
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "link";
            output.Attributes.SetAttribute("rel", "alternate");
            output.Attributes.SetAttribute("type", new HtmlString("application/rss+xml"));
            output.Attributes.SetAttribute("title", "Posts - CommunityPortal - RSS");
            output.Attributes.SetAttribute("href", GeneratedUrl());
        }
    }
}