using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CommunityPortal.Models;

namespace CommunityPortal.ViewModels
{
    public class CreatePostViewModel
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string CategoryId { get; set; }
        
        public Category Category { get; set; }
        [Required]
        [MaxLength(256)]
        public string Subject { get; set; }
        
        [Required]
        public string Content { get; set; }
        
        [Required] public List<string> Tags { get; set; }
    }
}