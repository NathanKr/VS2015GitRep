using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using FestMVC.Models;
using FestMvc.Models;

namespace FestMVC.Controllers.API
{
    public class EventsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Events
        /* public IQueryable<Event> GetEvents()
         {
             return db.Events;
         }*/



        /// <summary>
        /// GET
        /// api/Events/GetEvents
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IQueryable<Event> GetEvents()
        {
            return db.Events;
        }

        // GET: api/Events/GetEvent/5
        [ResponseType(typeof(Event))]
        [HttpGet]
        public IHttpActionResult GetEvent(long id)
        {
            Event oEvent = db.Events.Find(id);
            if (oEvent == null)
            {
                return NotFound();
            }

            return Ok(oEvent);
        }

        // PUT: api/Events/UpdateEvent/5
        [ResponseType(typeof(void))]
        [HttpPut]
        public IHttpActionResult UpdateEvent(long id, Event oEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oEvent.Id)
            {
                return BadRequest();
            }

            db.Entry(oEvent).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Events/CreateEvent
        [ResponseType(typeof(Event))]
        [HttpPost]
        public IHttpActionResult CreateEvent(Event oEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Events.Add(oEvent);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oEvent.Id }, oEvent);
        }

        // DELETE: api/Events/DeleteEvent/5
        [ResponseType(typeof(Event))]
        [HttpDelete]
        public IHttpActionResult DeleteEvent(long id)
        {
            Event oEvent = db.Events.Find(id);
            if (oEvent == null)
            {
                return NotFound();
            }

            db.Events.Remove(oEvent);
            db.SaveChanges();

            return Ok(oEvent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventExists(long id)
        {
            return db.Events.Count(e => e.Id == id) > 0;
        }
    }
}