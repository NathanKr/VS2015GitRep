using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class DefaultReadWriteController : Controller
    {
        // GET: DefaultReadWrite
        public ActionResult Index()
        {
            return View();
        }

        // GET: DefaultReadWrite/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DefaultReadWrite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DefaultReadWrite/Create
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

        // GET: DefaultReadWrite/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DefaultReadWrite/Edit/5
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

        // GET: DefaultReadWrite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DefaultReadWrite/Delete/5
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
