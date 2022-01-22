using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CommunityPortal.Factories
{
    public class CategoryFactory
    {
        public static Category Model(CreateCategoryViewModel createViewModel)
        {
            return new Category
            {
                Id = createViewModel.Id?? Guid.NewGuid().ToString(),
                Name = createViewModel.Name,
            };
        }

        public static CreateCategoryViewModel ViewModel(Category category)
        {
            return new CreateCategoryViewModel
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}