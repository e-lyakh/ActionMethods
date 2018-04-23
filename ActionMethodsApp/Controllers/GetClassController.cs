using ActionMethodsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionMethodsApp.Controllers
{
    public class GetClassController : Controller
    {
        List<Person> persons = new List<Person>
        {
            new Person { Name = "Ivan", Surname = "Ivanenko", Age = 22, Height = 166},
            new Person { Name = "Petro", Surname = "Petrenko", Age = 33, Height = 177},
            new Person { Name = "Dmytro", Surname = "Dmytrenko", Age = 44, Height = 188}
        };

        public ActionResult Class()
        {
            ViewBag.Persons = persons;
            return View();
        }

    }
}