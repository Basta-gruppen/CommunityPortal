using CommunityPortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.ViewModels
{
    public class CreateConversationViewModel
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Subject { get; set; }

        public List<string> Users { get; set; }
        public List<string> Messages { get; set; }
    }
}
