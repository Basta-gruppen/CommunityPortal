using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Factories;
using CommunityPortal.Models;
using CommunityPortal.Repositories;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommunityPortal.Controllers
{
    public class PostController : Controller
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly ApplicationDbContext _context;
        private readonly PostRepository _postRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public PostController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager,
            PostRepository postRepository, CategoryRepository categoryRepository)
        {
            _context = applicationDbContext;
            _userManager = userManager;
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
        }

        private IActionResult ListPosts()
        {
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Categories = _categoryRepository
                .GetAllAsViewModelList(_userManager.GetUserId(User))
                .ToList();

            return View(
                "Index",
                _postRepository.ToList()
            );
        }

        [HttpGet]
        [Route("/Posts/")]
        public IActionResult Index()
        {
            _postRepository
                .GetAll()
                .ByUserSubscribedCategory(_userManager.GetUserId(User));
            return ListPosts();
        }

        [HttpGet]
        [Route("/Posts/tag/{Tag}")]
        public IActionResult Index(string tag)
        {
            _postRepository
                .GetAll()
                .ByTag(tag);
            return ListPosts();
        }

        [HttpGet]
        [Route("/Posts/category/{category}")]
        public IActionResult Category(string category)
        {
            _postRepository
                .GetAll()
                .ByCategoryName(category);
            return ListPosts();
        }

        [HttpGet]
        [Route("/Post/{id}")]
        public new IActionResult View(string id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            var post = _postRepository.GetById(id);
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
            createViewModel.UserId = _userManager.GetUserId(User);
            _postRepository.Create(createViewModel);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CreatePostViewModel createViewModel)
        {
            _postRepository
                .Update(createViewModel);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var createPostViewModel = new CreatePostViewModel();
            ViewBag.Categories = _context.Categories.ToList();
            var post = _postRepository.GetById(id);
            if (post == null) return View(createPostViewModel);

            return View(PostFactory
                .CreateViewModel(post, _userManager.GetUserId(User)));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {
            try
            {
                _postRepository.Delete(id);
            }
            catch (DbUpdateException e)
            {
                return BadRequest(e.Message);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}