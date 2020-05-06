using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcTueTest.Models;

namespace MvcTueTest.Controllers
{
    public class KsoddController : Controller
    {

        public JsonResult GetKsodd()
        {
            
            
            List<Ksodd> ksodds = new List<Ksodd>();

            Ksodd ksodd = new Ksodd
            {
                Id = 1,
                Name = "КСОДДИЩЕ",
                OwnerName = "Администрация Нарнии",
                NameDeveloper = "Профессионал",
                DateApproval = new DateTime(2015, 7, 20),
                DateRegistration = DateTime.Now,
                EndDate = new DateTime(2020, 7, 20)
            };
            Ksodd ksodd2 = new Ksodd
            {
                Id = 2,
                Name = "КСОДДИЩЕ2",
                OwnerName = "Администрация Хогвардса",
                NameDeveloper = "Рональд Уизли",
                DateApproval = new DateTime(2016, 7, 20),
                DateRegistration = DateTime.Now,
                EndDate = new DateTime(2021, 7, 20)
            };
            
            
            Ksodd ksodd3 = new Ksodd
            {
                Id = 3,
                Name = "Комплексная схема организации дорожного движения",
                OwnerName = "Администрация Пуфендуя",
                NameDeveloper = "Разработчик КСОДД",
                DateApproval = new DateTime(2016, 7, 20),
                DateRegistration = DateTime.Now,
                EndDate = new DateTime(2021, 7, 20)
            };

            Ksodd ksodd4 = new Ksodd
            {
                Id = 4,
                Name = "Комплексная схема ОДД",
                OwnerName = "Администрация всех администраций",
                NameDeveloper = "Разработчик уровень 80",
                DateApproval = new DateTime(2020, 7, 20),
                DateRegistration = DateTime.Now,
                EndDate = new DateTime(2021, 12, 12)
            };
            
            Ksodd ksodd5 = new Ksodd
            {
                Id = 5,
                Name = "Комплексная схема ОДД 5555",
                OwnerName = "Администрация всех администраций",
                NameDeveloper = "Разработчик уровень 80",
                DateApproval = new DateTime(2020, 7, 20),
                DateRegistration = DateTime.Now,
                EndDate = new DateTime(2021, 12, 12)
            };
            
            
            ksodds.Add(ksodd);
            ksodds.Add(ksodd2);
            ksodds.Add(ksodd3);
            ksodds.Add(ksodd4);
            ksodds.Add(ksodd5);
            

            var result = new JsonResult(ksodds);
            return result;
        }
        
    }
}