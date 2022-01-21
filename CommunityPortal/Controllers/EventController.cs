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
            List<Event> ListOfPeople = _context.Events.OrderByDescending(e => e.Timestamp).ToList();
            return View(ListOfPeople);
            //return View(
            //    _context
            //        .Events
            //        .Include(ev => ev.Subject)
            //        .Include(ev => ev.Content)
            //        .Include(ev => ev.StartDate)
            //        .Include(ev => ev.User)
            //        .Include(ev => ev.Timestamp)
            //        .ToList());
        }
        public IActionResult CreateEvent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEvent(Event ev)
        {
            ev.UserId = _userManager.GetUserId(User);
           ev.Id = Guid.NewGuid().ToString();
          // ev.UserId = HttpContext.User.Identity.Ge 
          // ev.UserId = _context.Users.ToList()[0].Id;
            var errors = ModelState
    .Where(x => x.Value.Errors.Count > 0)
    .Select(x => new { x.Key, x.Value.Errors })
    .ToArray();
            //if (ModelState.IsValid)
            //{
                _context.Events.Add(ev);
                _context.SaveChanges();
                return RedirectToAction("Index");
            //}
            //else
            //{
                //return View();
            //}

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
        /*
         public IActionResult DeletePerson(int personId)
        {
            if (personId > 0)
            {
                var personbyId = _context.People.Where(x => x.PersonId == personId).FirstOrDefault();
                if (personbyId != null)
                {
                    _context.Entry(personbyId).State = EntityState.Deleted;
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("People");
        }
         */

        /*
         public class CustomerOrderDetailsController : Controller

{

[AcceptVerbs(HttpVerbs.Get)]

public ActionResult Index()

{

OrderDBEntities orderdb = new OrderDBEntities(); //dbcontect class

List<CustomerVM> CustomerVMlist = new List<CustomerVM>(); // to hold list of Customer and order details

var customerlist = (from Cust in orderdb.Customers

join Ord in orderdb.Orders on Cust.CustomerID equals Ord.CustomerID

selectnew { Cust.Name, Cust.Mobileno, Cust.Address, Ord.OrderDate, Ord.OrderPrice}).ToList();

//query getting data from database from joining two tables and storing data in customerlist

foreach (var item in customerlist)

{

CustomerVM objcvm = new CustomerVM(); // ViewModel

objcvm.Name = item.Name;

objcvm.Mobileno = item.Mobileno;

objcvm.Address = item.Address;

objcvm.OrderDate = item.OrderDate;

objcvm.OrderPrice = item.OrderPrice;

CustomerVMlist.Add(objcvm);

}

//Using foreach loop fill data from custmerlist to List<CustomerVM>.

return View(CustomerVMlist); //List of CustomerVM (ViewModel)

}

}
         
         */


    }
}
