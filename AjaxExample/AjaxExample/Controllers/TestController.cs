using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxExample.Models;

namespace AjaxExample.Controllers
{
    public class TestController : Controller
    {
        private const int nDefaultScoreNum = 3;
        // GET: AjaxRawJs
        public ActionResult AjaxRawJs()
        {
            return PartialView("_GetScorePartial", new TestModel()
            {
                ScoresNum = nDefaultScoreNum
            });
        }

        // GET: AjaxRawJsInForm
        public ActionResult AjaxRawJsInForm(int ScoresNum)
        {
            System.Threading.Thread.Sleep(2000);
            return PartialView("_GetScorePartial", new TestModel()
             {
                 ScoresNum = ScoresNum
             });
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.InternalServerError);
        }

        

        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
    }
}