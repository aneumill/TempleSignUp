using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleSignUp.Models;

namespace TempleSignUp.Controllers
{
    public class HomeController : Controller
    {
        private TourGroupContext context { get; set; }

        private readonly ILogger<HomeController> _logger;
        //Constructor
        public HomeController(ILogger<HomeController> logger, TourGroupContext con)
        {
            _logger = logger;
            context = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View(context.Times.OrderBy(p => p.Schedule));
        }
        
        public IActionResult ViewAppointments()
        {
            return View(context.Groups);
        }
        [HttpGet]
        public IActionResult BookingForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BookingForm(SignUpModel formsubmission)
        {
            if (ModelState.IsValid)
            {
                context.Groups.Add(formsubmission);
                context.SaveChanges();
                return View("Index" );
        
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
