using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class CategorySubscriber
    {
        [Required]
        public string CategoryId { get; set; }
        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
        public Category Category { get; set; }
    }
}
