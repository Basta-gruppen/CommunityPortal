using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class Event
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [MaxLength(256)]
        public string Subject { get; set; }

        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }  

        public ApplicationUser User { get; set; }
    }
}
