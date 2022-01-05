using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class Category
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        public List<CategorySubscriber> CategorySubscribers { get; set; }
        public List<Post> Posts { get; set; }
    }
}
