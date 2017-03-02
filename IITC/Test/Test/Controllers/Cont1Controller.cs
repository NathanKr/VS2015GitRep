using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;
using System.IO;
using Test.Logic;
using System.Threading;

namespace Test.Controllers
{
    public class Cont1Controller : Controller
    {
        private ApplicationDbContext db =
            new ApplicationDbContext();

        public ActionResult GetAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjaxAdd(ViewModelAddThree viewModel)
        {
            Thread.Sleep(3000);
            int result = viewModel.Number1 +
                viewModel.Number2 +
                viewModel.Number3;

            return PartialView("_Add", result);
        }


        // GET: /Cont1/Rand
        public ActionResult Rand()
        {
            return View();
        }

        // POST : /Cont1/ResultRandIncrement
        [HttpPost]
        public ActionResult ResultRandIncrement(ViewModelAdd viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Rand");
            }
            Random rnd = new Random();
            int nRand = rnd.Next(1, 10);
            int nResult = viewModel.Number + nRand;

            ViewModelResultRand result =
                    new ViewModelResultRand
                    {
                        Result = nResult,
                        Random = nRand
                    };

            db.Infos.Add(new Info
            {
                Number = viewModel.Number,
                Random = nRand , 
                Result = nResult
            });
            db.SaveChanges();

            return View(result);
        }

        // GET: /Cont1/Increment
        public ActionResult Increment()
        {
            return View();
        }

        // POST : /Cont1/ResultIncrement
        [HttpPost]
        public ActionResult ResultIncrement(ViewModelAdd viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Increment");
            }

            ViewModelResult result = 
                    new ViewModelResult { Result = ++viewModel.Number };

            return View(result);
        }

        public ActionResult GetSaveFile()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult SaveFile(ViewModelFile viewmodel)
        {
            if(ModelState.IsValid)
            { 
                string strDirectory = 
                    Path.Combine(Utils.GetServerRoot(Server),
                    "Storage");
                string strFilePath =
                    Path.Combine(strDirectory, 
                    viewmodel.File.FileName);
                viewmodel.File.SaveAs(strFilePath);
                return RedirectToAction("Index", "Home");
            }

            return View("GetSaveFile");
        }
    }
}