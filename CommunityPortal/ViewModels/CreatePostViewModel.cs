using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CommunityPortal.ViewModels
{
    public class CreatePostViewModel
    {
        [Key] public string Id { get; set; }

        [Required] public string UserId { get; set; }
        
        [DisplayName("Category")]
        [Required] public string CategoryId { get; set; }

        public Category Category { get; set; }

        [Required] [MaxLength(256)] public string Subject { get; set; }

        [Required] public string Content { get; set; }

        [Required]
        public List<Tag> Tags { get; set; }

        public string[] SelectedTagIds { get; set; } = { };

        [DisplayName("Tags")]
        public List<SelectListItem> TagList { get; set; } =
            new List<SelectListItem> {new SelectListItem("Tag", "", false)};
    }
}