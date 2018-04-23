using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionMethodsApp.Controllers
{
    public class GetPdfController : Controller
    {
        // GET: GetPdf
        public ActionResult Pdf()
        {
            return View();
        }

        public FileResult GetFile()
        {
            string path = Server.MapPath("~/Files/sample.pdf");
            string type = "application/pdf";
            string name = "sample.pdf";
            return File(path, type, name);
        }
    }
}