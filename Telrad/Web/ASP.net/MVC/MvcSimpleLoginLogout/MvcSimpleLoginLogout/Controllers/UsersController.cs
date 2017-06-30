using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSimpleLoginLogout.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName , string password) // use here same name Login - more intuitive
        {
            // -- no need for validation because i put nothing to storage
            bool bDoesExist = (userName == "Avi") && (password == "31aB_$");// -- hard code
            if (!bDoesExist)
            {
                ViewBag.LoginError = "Login is not valid";
                return View("Login");
            }


            Session["userSessionKey"] = userName;
            return RedirectToAction("Home"); ;
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session["userSessionKey"] = null;
            return RedirectToAction("Home");
        }
    }
}
