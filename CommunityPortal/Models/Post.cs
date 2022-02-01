using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class Post
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }

        [Required]
        public string CategoryId { get; set; }
        [Required]
        [MaxLength(256)]
        public string Subject { get; set; }

        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
        
     


        public Category Category { get; set; }
        public ApplicationUser User { get; set; }
        public List<PostTag> PostTags { get; set; }

        public static explicit operator Post(Event @event)
        {
            return new Post
            {
                Id = @event.Id,
                UserId = @event.UserId,
                CategoryId = "0",
                Subject = @event.Subject,
                Content = @event.Content,
                Timestamp = @event.Timestamp
            };
        }
    }
}
