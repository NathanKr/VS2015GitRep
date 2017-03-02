using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FestMVC.Models;

namespace FestMVC.Controllers
{
    public class Festival11Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Festival11
        public ActionResult Index()
        {
            return View(db.Festival1.ToList());
        }

        // GET: Festival11/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Festival1 festival1 = db.Festival1.Find(id);
            if (festival1 == null)
            {
                return HttpNotFound();
            }
            return View(festival1);
        }

        // GET: Festival11/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Festival11/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Festival1 festival1)
        {
            if (ModelState.IsValid)
            {
                db.Festival1.Add(festival1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(festival1);
        }

        // GET: Festival11/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Festival1 festival1 = db.Festival1.Find(id);
            if (festival1 == null)
            {
                return HttpNotFound();
            }
            return View(festival1);
        }

        // POST: Festival11/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Festival1 festival1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(festival1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(festival1);
        }

        // GET: Festival11/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Festival1 festival1 = db.Festival1.Find(id);
            if (festival1 == null)
            {
                return HttpNotFound();
            }
            return View(festival1);
        }

        // POST: Festival11/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Festival1 festival1 = db.Festival1.Find(id);
            db.Festival1.Remove(festival1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
