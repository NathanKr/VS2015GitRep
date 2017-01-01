using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxExample.Controllers
{
    public class TestController : Controller
    {
        // GET: AjaxRawJS
        public ActionResult AjaxRawJS()
        {
            return PartialView("_GetScorePartial");
        }

        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
    }
}