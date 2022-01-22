using System.ComponentModel.DataAnnotations;

namespace CommunityPortal.ViewModels
{
    public class CategoryViewModel
    {
        [Key] public string Id { get; set; }
        [Required] public string CategoryId { get; set; }
        [Required] public string Name { get; set; }
        [Required] public bool IsSubscribed { get; set; }
        [Required] public int PostCount { get; set; }
    }
}