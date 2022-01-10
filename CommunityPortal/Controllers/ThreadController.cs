using Microsoft.AspNetCore.Mvc;

namespace CommunityPortal.Controllers
{
    public class ThreadController : Controller
    {
        // GET
        public IActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }
            
            return View();
        }
    }
}