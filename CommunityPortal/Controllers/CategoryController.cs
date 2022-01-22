using System.Linq;
using CommunityPortal.Models;
using CommunityPortal.Repositories;
using CommunityPortal.ViewModels;
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
        
        [HttpGet]
        [Route("/Category/Edit/{id}")]
        public IActionResult Edit(string id)
        {
            var category = _categoryRepository.GetById(id);
            ViewBag.Category = new CreateCategoryViewModel
            {
                Id = category.Id,
                Name = category.Name
            };
            return Index();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CreateCategoryViewModel createViewModel)
        {
            _categoryRepository
                .Update(createViewModel);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("/Categories/")]
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            ViewBag.RSS = Url.Action(
                "Index",
                "Feed",
                new
                {
                    categories = string.Join(",", _categoryRepository
                        .GetAllAsViewModelList(userId)
                        .GetUserSubscribed(userId)
                        .ToList()
                        .Select(x => x.Name)
                    )
                });

            return View(
                "Index",
                _categoryRepository
                    .GetAllAsViewModelList(userId)
                    .ToList()
            );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateCategoryViewModel createViewModel)
        {
            _categoryRepository.Create(createViewModel);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Subscribe(string id)
        {
            _categoryRepository.Subscribe(
                id,
                _userManager.GetUserId(User)
            );

            return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public IActionResult UnSubscribe(string id)
        {
            _categoryRepository.Unsubscribe(
                id,
                _userManager.GetUserId(User)
            );

            return RedirectToAction("Index", "Category");
        }
    }
}