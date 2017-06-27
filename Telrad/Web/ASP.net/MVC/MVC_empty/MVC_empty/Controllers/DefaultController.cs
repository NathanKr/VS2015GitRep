using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_empty.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            string virtualFile = "~/storage/books.txt";
            string physicalFile = Server.MapPath(virtualFile);
            string[] arFileLines = System.IO.File.ReadAllLines(physicalFile);

            return View(arFileLines);
        }
    }
}