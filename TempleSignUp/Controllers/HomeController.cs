using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleSignUp.Models;
using TempleSignUp.Models.ViewModel;

namespace TempleSignUp.Controllers
{
    public class HomeController : Controller
    {
        private TourGroupContext context { get; set; }

        private readonly ILogger<HomeController> _logger;
        //Constructor for the controller. Passes in the DBcontext models. 
        public HomeController(ILogger<HomeController> logger, TourGroupContext con)
        {
            _logger = logger;
            //set context to the passed in model to be used in the controller
            context = con;
        }

        //Returns the Index view on load
        public IActionResult Index()
        {
            return View();
        }
        //The get action for the sign up model where the Sign-Up times are viewed
        [HttpGet]
        public IActionResult SignUp()
        {
            //Returns the scheduled times ordered by the dates in teh context times schedule
            return View(context.Times.OrderBy(p => p.Schedule));
        }
        [HttpPost]
        public IActionResult SignUp(SlottedTime s)
        {
            //Returns the Book form, generates a new ViewAppointmentList model set 
            return View("BookingForm", new ViewApppointmentList
            {
                slottedtime = s
            });  ;
        }

       
        public IActionResult ViewAppointments()
        {
            //Returns the DbConxext Groups
            return View(context.Groups);
        }
        [HttpGet]
        public IActionResult BookingForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BookingForm(ViewApppointmentList formsubmission)
        { 
            if (ModelState.IsValid)
            {
                context.Groups.Add(formsubmission.signup);
                //Make the slotted time model queryable and set the return value where the ViewAppointmentList Model matches the slotted times model 
                IQueryable<SlottedTime> queryabletimes = context.Times.Where(t => t.SlottedTimeID == formsubmission.slottedtime.SlottedTimeID);
                //Loop through the querable variable and change the availbility on the instance where the two table match.
                foreach (var x in queryabletimes)
                {
                    x.Availbility = false;
                }
                //Save the changes made to the database
                context.SaveChanges();
                //Return the Home page
                return View("Index");
            }
            else
            {
                //If the form model is valid repass in the form submission 
                return View(formsubmission);
            }
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
