using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_empty.Logic;
using MVC_empty.Models;

namespace MVC_empty.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            string virtualFile = "~/storage/books.txt";
            string physicalFile = Server.MapPath(virtualFile);
            string[] arFileLines = System.IO.File.ReadAllLines(physicalFile);
            ;
            List<Book> listBooks = new List<Book>();

            foreach (string strBookLine in arFileLines)
            {
                string[] arLineSplited = strBookLine.Split(',');

                Book book = new Book
                {
                    Name = arLineSplited[0],
                    Category = arLineSplited[1],
                    PageNum = int.Parse(arLineSplited[2])
                };
                listBooks.Add(book);
            }

            return View(listBooks);
        }


        [HttpGet] //this is default
        public ActionResult DoesBookExist()
        {
            return View();
        }

        [HttpGet] //this is default
        public ActionResult HandleDoesBookExist(string name)
        {
            bool bIsValid = name.Length > 0;// --- some kind of validation to show what is done

            if (!bIsValid){
                ViewBag.Error = "name is not valid";
                return View("DoesBookExist");
            }

            bool bDoesExist = Utils.DoesBookExist(Server,name);

            return View(bDoesExist);
        }
    }
}
    