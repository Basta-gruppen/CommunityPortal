using CommunityPortal.Models;
using CommunityPortal.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CommunityPortal.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public CategoryController(UserManager<ApplicationUser> userManager, CategoryRepository categoryRepository)
        {
            _userManager = userManager;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Subscribe(string id)
        {
            _categoryRepository.Subscribe(
                id,
                _userManager.GetUserId(User)
            );

            return RedirectToAction("Index", "Post");
        }

        public IActionResult UnSubscribe(string id)
        {
            _categoryRepository.Unsubscribe(
                id,
                _userManager.GetUserId(User)
            );

            return RedirectToAction("Index", "Post");
        }
    }
}