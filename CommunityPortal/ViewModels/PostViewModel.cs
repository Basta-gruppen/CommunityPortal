using System;
using System.Collections.Generic;
using System.Linq;
using CommunityPortal.Models;

namespace CommunityPortal.ViewModels
{
    public class PostViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public int TotalPosts { get; set; }  
        public int PostsPerPage { get; set; }  
        public int CurrentPage { get; set; }  
  
        public int PageCount()  
        {  
            return Convert.ToInt32(Math.Ceiling(TotalPosts / (double)PostsPerPage));  
        }  
        public IEnumerable<Post> PaginatedPosts()  
        {  
            var start = (CurrentPage - 1) * PostsPerPage;  
            return Posts.OrderBy(b=>b.Id).Skip(start).Take(PostsPerPage);  
        } 
    }
}