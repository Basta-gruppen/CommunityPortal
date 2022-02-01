using CommunityPortal.Data;
using CommunityPortal.Models;
using CommunityPortal.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
        private readonly UserManager<ApplicationUser> userManager;

        public ConversationController(ApplicationDbContext context,UserManager<ApplicationUser> applicationUser)
        {
            dbContext = context;
            userManager = applicationUser;
        }
        
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserIndex()
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

            List<ApplicationUser> users = dbContext.Users.Where(u => u.Id != currentUserID).ToList();
            return PartialView("_UserPartial",users);
        }


        [HttpGet]
        public IActionResult Conversation()
        {
            var currentUser = userManager.GetUserId(User);
           
            List<Conversation> userConversations = dbContext.UserConversations.Include(uc => uc.Conversation)
                .Where(uc => uc.UserId == currentUser).Select(uc => uc.Conversation).ToList();

           
            return PartialView("_ConversationPartialView",userConversations);
        } 
        public IActionResult Create()
        { return View(); }
        [HttpPost]
        public IActionResult Create(CreateConversationViewModel createConversation, string id)
        {
            //if (dbContext.UserConversations.Any(uc => uc.UserId == id))
            //{
            //    return BadRequest("Conversation is created With This User Select From Conversation");
            //}
            if(ModelState.IsValid)
            { 
            Conversation newConversation = new Conversation()
            {
                Id = Guid.NewGuid().ToString(),
                Subject = createConversation.Subject
            };


            dbContext.Add(newConversation);
            dbContext.SaveChanges();

            List<UserConversation> userConversations = new List<UserConversation>()
            {
                new UserConversation()
                {
                    ConversationId=newConversation.Id,
                    UserId= userManager.GetUserId(User)
                },
                new UserConversation()
                {
                    ConversationId=newConversation.Id,
                    UserId=id
                }
            };

            dbContext.UserConversations.AddRange(userConversations);

            dbContext.SaveChanges();
            ViewBag.Message = "Conversation is created";


            }
            //return RedirectToAction("Conversation");
            return View();
        }
        
        
        
        public IActionResult Delete(string id)
        {
           
            dbContext.Conversations.Remove(dbContext.Conversations.Find(id));
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
