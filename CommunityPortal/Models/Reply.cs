using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class Reply
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string ThreadId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime TimeStamp { get;set; }

        public string QuoteId { get; set; }
        public Reply Quote { get; set; }

        public ApplicationUser User { get; set; }
        public Thread Thread { get; set; }




    }
}
