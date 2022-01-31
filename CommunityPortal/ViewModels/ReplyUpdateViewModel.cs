using System.ComponentModel.DataAnnotations;

namespace CommunityPortal.ViewModels
{
    public class ReplyUpdateViewModel
    {
        [Required] public string ReplyId { get; set; }
        [Required] public string Content { get; set; }
        public string QuoteId { get; set; }
    }
}