using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Data;
using CommunityPortal.Factories;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;

namespace CommunityPortal.Repositories
{
    public class CategoryRepository
    {
        private readonly ApplicationDbContext _context;
        private IQueryable<CategoryViewModel> _categoryViewModels;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public Category GetById(string id)
        {
            return _context.Categories
                .FirstOrDefault(category => category.Id == id);
        }

        public CategoryRepository GetAllAsViewModelList(string userId)
        {
            _categoryViewModels = (from category in _context.Categories
                select new
                {
                    Category = category,
                    IsSubscribed = from categorySubscriber in category.CategorySubscribers
                        where categorySubscriber.UserId == userId && categorySubscriber.CategoryId == category.Id
                        select categorySubscriber.UserId == userId && categorySubscriber.CategoryId == category.Id,
                    PostCount = category.Posts.Count
                }).Select(x => new CategoryViewModel
            {
                Id = x.Category.Id,
                Name = x.Category.Name,
                IsSubscribed = x.IsSubscribed.FirstOrDefault(),
                PostCount = x.PostCount
            });

            return this;
        }
        
        public CategoryRepository Create(CreateCategoryViewModel createViewModel)
        {
            var category = CategoryFactory.Model(createViewModel);

            _context.Categories.Add(category);
            _context.SaveChanges();

            return this;
        }
        public CategoryRepository Update(Category category, CreateCategoryViewModel createViewModel)
        {
            category.Name = createViewModel.Name;
            _context.SaveChanges();
            return this;
        }

        public CategoryRepository Update(CreateCategoryViewModel createViewModel)
        {
            return Update(GetById(createViewModel.Id), createViewModel);
        }
        public CategoryRepository Subscribe(string id, string userId)
        {
            _context.CategorySubscribers.Add(new CategorySubscriber
            {
                CategoryId = id,
                UserId = userId
            });
            _context.SaveChanges();

            return this;
        }

        public CategoryRepository Unsubscribe(CategorySubscriber categorySubscriber)
        {
            _context.CategorySubscribers.Remove(categorySubscriber);
            _context.SaveChanges();
            return this;
        }

        public CategoryRepository Unsubscribe(string id, string userId)
        {
            return Unsubscribe(_context.CategorySubscribers
                .FirstOrDefault(x => x.UserId.Equals(userId) && x.CategoryId.Equals(id))
            );
        }
        
        public CategoryRepository GetUserSubscribed(string userId)
        {
            _categoryViewModels = _categoryViewModels.Where(x => x.IsSubscribed.Equals(true));
           // _categoryViewModels = GetAllAsViewModelList(userId)._categoryViewModels.Where(x => x.IsSubscribed.Equals(true));
            return this;
        }
        
        public List<CategoryViewModel> ToList()
        {
            return _categoryViewModels.ToList();
        }
    }
}