using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CommunityPortal.Controllers
{
    public class ConversationController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ConversationController(ApplicationDbContext context)
        {
            dbContext = context;
        }
        
        public IActionResult Index()
        {
            //ClaimsPrincipal currentUser = this.User;
            //var CurrentUserName = currentUser.Identity.Name.ToString();

            //ViewBag.AllUser = dbContext.Users.Where(u => u.UserName != CurrentUserName).ToList();
            List<ApplicationUser> users= dbContext.Users.ToList();

            return View(users);
        }
       
        
       
         

        public IActionResult CreateConversation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateConversation(string id)
        {
            //if (ModelState.IsValid)
            //{
            //    dbContext.Conversations.Add(conversation);
            //    dbContext.SaveChanges();
            //    RedirectToAction("Conversation");
            //}


            List<Message> messages = new List<Message>()
            {
                new Message()
                {
                    Content=id,
                    UserId=Guid.NewGuid().ToString(),
                    ConversationId=Guid.NewGuid().ToString(),
                    TimeStamp=new DateTime()
                }
            };
            return PartialView("_MessagePartialView", messages);

            //return View();
        }


    }
}
