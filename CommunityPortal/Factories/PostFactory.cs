using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CommunityPortal.Factories
{
    public class PostFactory
    {
        public static Post Model(CreatePostViewModel createViewModel, string userId = null)
        {
            return new Post
            {
                Id = createViewModel.Id?? Guid.NewGuid().ToString(),
                UserId = createViewModel.UserId?? userId,
                Subject = createViewModel.Subject,
                CategoryId = createViewModel.CategoryId,
                Content = createViewModel.Content,
                //TODO: Add updatedTimestamp?
                Timestamp = DateTime.Now
            };
        }

        public static CreatePostViewModel ViewModel(Post post, string userId)
        {
            var createPostViewModel = new CreatePostViewModel
            {
                Id = post.Id,
                UserId = userId,
                Subject = post.Subject,
                CategoryId = post.CategoryId,
                Content = post.Content,
                SelectedTagIds = post.PostTags.Select(x => x.TagId).ToArray()
            };
            createPostViewModel.TagList
                .AddRange(
                    post.PostTags.Select(
                        x => new SelectListItem(x.Tag.Name, x.Tag.Id)
                    )
                );
            return createPostViewModel;
        }
    }
}