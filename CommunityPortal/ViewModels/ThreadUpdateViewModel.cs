using System.ComponentModel.DataAnnotations;

namespace CommunityPortal.ViewModels
{
    public class  ThreadUpdateViewModel
    {
        [Required] public string ThreadId { get; set; }
        [Required][MaxLength(256)] public string Subject { get; set; }
        [Required] public string Content { get; set; }
    }
}