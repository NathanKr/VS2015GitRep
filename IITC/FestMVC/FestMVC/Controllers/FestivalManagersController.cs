﻿using System;
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
    public class FestivalManagersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FestivalManagers
        public ActionResult Index()
        {
            return View(db.FestivalManagers.ToList());
        }

        // GET: FestivalManagers/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FestivalManager festivalManager = db.FestivalManagers.Find(id);
            if (festivalManager == null)
            {
                return HttpNotFound();
            }
            return View(festivalManager);
        }

        // GET: FestivalManagers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FestivalManagers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId")] FestivalManager festivalManager)
        {
            if (ModelState.IsValid)
            {
                db.FestivalManagers.Add(festivalManager);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(festivalManager);
        }

        // GET: FestivalManagers/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FestivalManager festivalManager = db.FestivalManagers.Find(id);
            if (festivalManager == null)
            {
                return HttpNotFound();
            }
            return View(festivalManager);
        }

        // POST: FestivalManagers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId")] FestivalManager festivalManager)
        {
            if (ModelState.IsValid)
            {
                db.Entry(festivalManager).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(festivalManager);
        }

        // GET: FestivalManagers/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FestivalManager festivalManager = db.FestivalManagers.Find(id);
            if (festivalManager == null)
            {
                return HttpNotFound();
            }
            return View(festivalManager);
        }

        // POST: FestivalManagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            FestivalManager festivalManager = db.FestivalManagers.Find(id);
            db.FestivalManagers.Remove(festivalManager);
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
