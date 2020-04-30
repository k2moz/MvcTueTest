using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcTueTest.Models;

namespace MvcTueTest.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }
        
        
        public JsonResult GetUser()
        {
            
            
            List<Person> people = new List<Person>();
            
            Person sam = new Person
            {
                Id = 1,
                FirstName = "Sam",
                LastName = "Weetwuicky"
            };
            
            Person bob = new Person
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Tornton"
            };
            
            
            people.Add(sam);
            people.Add(bob);
            
            
//            var result = new JsonResult(person);
            var result = new JsonResult(people);
            return result;
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
