using CommunityPortal.Data;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CommunityPortal.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EventController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            List<Event> ListOfPeople = _context.Events.Include(u => u.User).OrderByDescending(e => e.Timestamp).ToList();
            return View(ListOfPeople);
        }
        public IActionResult CreateEvent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEvent(Event ev)
        {
            ev.Timestamp = DateTime.Now;
            ev.UserId = _userManager.GetUserId(User);
           ev.Id = Guid.NewGuid().ToString();
          // ev.UserId = HttpContext.User.Identity.Ge 
          // ev.UserId = _context.Users.ToList()[0].Id;
            var errors = ModelState
    .Where(x => x.Value.Errors.Count > 0)
    .Select(x => new { x.Key, x.Value.Errors })
    .ToArray();
                _context.Events.Add(ev);
                _context.SaveChanges();
                return RedirectToAction("Index");
            
        }

        public IActionResult EditEvent(String eventId)
        {
            var eventData =_context.Events.Where(x => x.Id == eventId).FirstOrDefault();
            if(eventData != null)
            {
                TempData["EventId"] = eventId;
                TempData.Keep();
                return View(eventData);
            }
            return View();
        }
         [HttpPost]
         public IActionResult EditEvent(Event ev)
         {
            string eventId = (TempData["EventId"]).ToString();
            var eventData = _context.Events.Where(x => x.Id == eventId).FirstOrDefault();
            if(eventData != null)
            {
                eventData.Subject = ev.Subject;
                eventData.Content = ev.Content;
                eventData.StartDate = ev.StartDate;
                eventData.Timestamp = DateTime.Now;
                _context.Entry(eventData).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
         }

        public IActionResult DeleteEvent(string eventId)
        {
            if(!String.IsNullOrEmpty(eventId))
            {
                var eventbyId = _context.Events.Where(x => x.Id == eventId).FirstOrDefault();
                if(eventbyId != null)
                {
                    _context.Entry(eventbyId).State = EntityState.Deleted;
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }



    }
}
