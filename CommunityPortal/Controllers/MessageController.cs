using CommunityPortal.Data;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System; 
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Controllers
{
    public class MessageController : Controller
    { 
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public MessageController(ApplicationDbContext context, UserManager<ApplicationUser> applicationUser)
        {
            dbContext = context;
            userManager = applicationUser;
        }
        public IActionResult Index(string id)
        {
            List<Message> message = dbContext.Messages.Include(m => m.User).ThenInclude(c => c.UserConversations).Where
                (c => c.ConversationId == id).OrderBy(m => m.TimeStamp).ToList();

            Conversation conversation =
                dbContext.Conversations
                    .Include(c => c.Messages)
                    .FirstOrDefault(c => c.Id == id);

            if (conversation == null)
                return NotFound();

            

            return View(conversation);

            
        }
        /*public IActionResult Create()
        { return View(); }*/
        [HttpPost]
        public IActionResult Create(string content,string id)
        { 
            Message messages = new Message()
            {
                Id = Guid.NewGuid().ToString(),
                Content = content,
                ConversationId = id,
                UserId = userManager.GetUserId(User),
                TimeStamp = DateTime.Now 
            };
            dbContext.Messages.Add(messages);
            dbContext.SaveChanges();


            IEnumerable<Message> allMessages = dbContext.Messages
                .Include(m => m.User)
                .Where(m => m.ConversationId == id)
                .OrderBy(m=>m.TimeStamp)
                .ToList();
            
            return PartialView("_MessagePartial", allMessages);
            //return View();
            //return RedirectToAction("MessageInConversation");
        }


        //public IActionResult MessageInConversation() { return View(); }
        //[HttpPost]
        public IActionResult MessageInConversation(string id) 
        {
            //List<Message> messages = dbContext.Messages
            //    .Include(m => m.Conversation)
            //    .ThenInclude(m => m.Messages)
            //    .Where(m=>m.ConversationId==id).ToList();
            Conversation conversation = dbContext.Conversations
             .Include(m => m.Messages)
             .ThenInclude(u => u.User)
             .FirstOrDefault(c => c.Id == id);
            return PartialView("_MessagePartialView", conversation);
        }

        public IActionResult Delete(string id)
        {
            var message = dbContext.Messages.Find(id);
            dbContext.Messages.Remove(message);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index),new { id = message.ConversationId });
           
        }

    }
}
