using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionMethodsApp.Controllers
{
    public class GetImagesController : Controller
    {
        // GET: GetImages
        public ActionResult Images()
        {
            return View();
        }

        public ActionResult GetJpg()
        {
            string path = "../Files/image_1.jpg";
            //ViewBag.JpgPath = path;
            return new ImageResult(path);
        }

        public ActionResult GetPng()
        {
            string path = "../Files/image_2.png";
            //ViewBag.PngPath = path;
            return new ImageResult(path);
        }
    }
}