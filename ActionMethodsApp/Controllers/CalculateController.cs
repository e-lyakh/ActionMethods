using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionMethodsApp.Controllers
{
    public class CalculateController : Controller
    {      

        [HttpGet]
        public ActionResult Square()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult ShowSquare()
        {            
            double radius = Convert.ToDouble(Request.Form["radius"]);
            double square = radius * radius * Math.PI;
            ViewBag.Radius = radius;
            ViewBag.Square = Math.Round(square, 2);
            return View();
        }
    }
}