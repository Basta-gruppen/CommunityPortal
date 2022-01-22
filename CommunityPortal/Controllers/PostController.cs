using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Factories;
using CommunityPortal.Models;
using CommunityPortal.Repositories;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

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

        protected IPagedList<Post> GetPagedPosts(int? page)
        {
            // return a 404 if user browses to before the first page
            if (page < 1)
                return null;

            // retrieve list from database/whereverand
            var listUnpaged = _postRepository.ToList();

            // page the list
            const int pageSize = 1;
            var listPaged = listUnpaged.ToPagedList(page ?? 1, pageSize);

            // return a 404 if user browses to pages beyond last page. special case first page if no items exist
            if (listPaged.PageNumber != 1 && page.HasValue && page > listPaged.PageCount)
                return null;

            return listPaged;
        }

        private IActionResult ListPosts(int page)
        {
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Categories = _categoryRepository
                .GetAllAsViewModelList(_userManager.GetUserId(User))
                .ToList();
            return View(
                "Index",
                GetPagedPosts(page)
            );
        }

        [HttpGet]
        [Route("/Posts/{page:int?}")]
        public IActionResult Index(int page = 1)
        {
            _postRepository
                .GetAll()
                .ByUserSubscribedCategory(_userManager.GetUserId(User));
            return ListPosts(page);
        }

        [HttpGet]
        [Route("/Posts/tag/{Tag}/{page:int?}")]
        public IActionResult Index(string tag, int page = 1)
        {
            _postRepository
                .GetAll()
                .ByTag(tag);
            return ListPosts(page);
        }

        [HttpGet]
        [Route("/Posts/category/{category}/{page:int?}")]
        public IActionResult Category(string category, int page = 1)
        {
            _postRepository
                .GetAll()
                .ByCategoryName(category);
            return ListPosts(page);
        }

        [HttpGet]
        [Route("/Post/{id}")]
        public new IActionResult View(string id)
        {
            ViewBag.Categories = ViewBag.Categories = _categoryRepository
                .GetAllAsViewModelList(_userManager.GetUserId(User))
                .ToList();
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
                .ViewModel(post, _userManager.GetUserId(User)));
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