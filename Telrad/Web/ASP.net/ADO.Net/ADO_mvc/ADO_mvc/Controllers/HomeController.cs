using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ADO_mvc.Logic;
using ADO_mvc.Models;

namespace ADO_mvc.Controllers
{
    public class HomeController : Controller
    {

        [HttpPost]            
        public ActionResult AddEntry(string firstNameUser, string lastNameUser)
        {
            string strConnectionString = AdoHelper.GetConnectionString();

            UsersHelper.AddEntry(firstNameUser, lastNameUser, strConnectionString);

            return RedirectToAction("Index");
        }

        

        public ActionResult Index()
        {
            List<User> list = UsersHelper.GetUserList();

            return View(list);
        }

        
    }
}