using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class Cont2Controller : Controller
    {
        // GET: Cont2
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cont2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cont2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cont2/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cont2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cont2/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cont2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cont2/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
