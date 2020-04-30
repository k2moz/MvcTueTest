using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcTueTest.Models;

namespace MvcTueTest.Controllers
{
    public class CarController : Controller
    {
        // GET
//        public IActionResult Index()
//        {
//            return
//            View();
//        }
        
        
        
        public JsonResult GetCar()
        {
            
            
            List<Car> cars = new List<Car>();
            
            Car gtr = new Car
            {
                Id = 1,
                Name = "Nissan",
                Model = "GTR"
            };
            
            Car sls = new Car
            {
                Id = 2,
                Name = "Mersedes",
                Model = "SLS"
            };
            Car uaz = new Car
            {
                Id = 3,
                Name = "Uaz",
                Model = "Patriot"
            };
            Car vaz = new Car
            {
                Id = 4,
                Name = "Vaz",
                Model = "Семёрочка"
            };
            Car mazda = new Car
            {
                Id = 5,
                Name = "Mazda",
                Model = "Mazda-3"
            };
            
            
            cars.Add(gtr);
            cars.Add(sls);
            cars.Add(uaz);
            cars.Add(vaz);
            cars.Add(mazda);
            
            
//            var result = new JsonResult(person);
            var result = new JsonResult(cars);
            return result;
        }
    }
}