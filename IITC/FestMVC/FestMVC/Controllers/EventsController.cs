using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FestMVC.Models;
using FestMvc.Models;
using Microsoft.AspNet.Identity;

namespace FestMVC.Controllers
{
    public class EventsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        /// <summary>
        /// register logged in user
        /// </summary>
        /// <param name="id">event id</param>
        /// <returns></returns>
        public ActionResult RegisterToEvent(long id)
        {
            if (Request.IsAuthenticated)
            {
                Enrollment enrollment = new Enrollment
                {
                    UserId = User.Identity.GetUserId(),
                    EventId = id
                };
                db.Enrollments.Add(enrollment);
                db.SaveChanges();
                return RedirectToAction("GetFestivalEvents", 
                    "Events", new {id = id });
            }
            else
            {
                return RedirectToAction("Register", "Account");
            }
        }

        /// <summary>
        /// GET: Events/GetFestivalEvents/1
        /// </summary>
        /// <param name="id"> id of festival</param>
        /// <returns></returns>
        public ActionResult GetFestivalEvents(long? id)
        {
            if(id != null)
            {
                return View("Index", 
                    db.Events.Where(m=> m.Festival1Id == id).ToList());
            }

            return View("Index", db.Events.ToList());
        }

        // GET: Events
        public ActionResult Index()
        {
            return View(db.Events.ToList());
        }

        // GET: Events/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            ViewBag.Festival1Id =
               new SelectList(db.Festival1, "Id", "Name");

            ViewBag.InstructorId =
               new SelectList(db.Instructors, "Id", "Id");

            ViewBag.RoomId =
              new SelectList(db.Rooms, "Id", "Name");

            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,StartTime,EndTime,StartDate,EndDate,Festival1Id,InstructorId,RoomId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(@event);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(@event);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,StartTime,EndTime,StartDate,EndDate,Festival1Id,InstructorId,RoomId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
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
