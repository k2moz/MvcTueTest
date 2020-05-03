using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcTueTest.Models;

namespace MvcTueTest.Controllers
{
    public class PoddController : Controller
    {
        public JsonResult GetPodd()
        {
            
            
            List<Podd> podds = new List<Podd>();

            Podd podd = new Podd
            {
                Id = 1,
                Name = "ПОДДИК",
                OwnerName = "Администрация Нарнии",
                NameDeveloper = "Профессионал",
                DateApproval = new DateTime(2015, 7, 20),
                DateRegistration = DateTime.Now,
                EndDate = new DateTime(2020, 7, 20)
            };
            Podd podd2 = new Podd
            {
                Id = 2,
                Name = "План на план",
                OwnerName = "Администрация Хогвардса",
                NameDeveloper = "Рональд Уизли",
                DateApproval = new DateTime(2016, 7, 20),
                DateRegistration = DateTime.Now,
                EndDate = new DateTime(2021, 7, 20)
            };
            
            
            Podd podd3 = new Podd
            {
                Id = 3,
                Name = "План обследования дорожного движения",
                OwnerName = "Администрация Пуфендуя",
                NameDeveloper = "Разработчик КСОДД",
                DateApproval = new DateTime(2016, 7, 20),
                DateRegistration = DateTime.Now,
                EndDate = new DateTime(2021, 7, 20)
            };
            
            
            podds.Add(podd);
            podds.Add(podd2);
            podds.Add(podd3);
            

            var result = new JsonResult(podds);
            return result;
        }
    }
}