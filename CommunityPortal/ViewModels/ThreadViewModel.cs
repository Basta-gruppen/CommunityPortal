using CommunityPortal.Models;

namespace CommunityPortal.ViewModels
{
    public class ThreadViewModel
    {
        public Thread Thread { get; set; }
        public bool IsOwner { get; set; }
    }
}