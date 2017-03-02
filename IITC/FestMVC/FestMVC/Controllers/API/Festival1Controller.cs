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
    public class Festival1Controller : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        /// <summary>
        /// get event for this festival 
        /// </summary>
        /// <param name="id">festival id</param>
        /// <returns></returns>
        [HttpGet]
        public ICollection<Event> GetEvents(long id)
        {
            Festival1 festival = db.Festival1.Find(id);
            if (festival == null)
            {
                return null;
            }

            return festival.Events;
        }

        [HttpGet]
        [ResponseType(typeof(ICollection<Event>))]
        public IHttpActionResult  GetEventsTry(long id)
        {
            Festival1 festival = db.Festival1.Find(id);
            if (festival == null)
            {
                return NotFound();
            }

            return Ok(festival.Events);
        }

        // GET: api/Festival1/GetFestivals
        [HttpGet]
        public IQueryable<Festival1> GetFestivals()
        {
            return db.Festival1;
        }

        // GET: api/Festival1/GetFestival/5
        [ResponseType(typeof(Festival1))]
        [HttpGet]
        public IHttpActionResult GetFestival(long id)
        {
            Festival1 festival1 = db.Festival1.Find(id);
            if (festival1 == null)
            {
                return NotFound();
            }

            return Ok(festival1);
        }

        // PUT: api/Festival1/UpdateFestival/5
        [ResponseType(typeof(void))]
        [HttpPut]
        public IHttpActionResult UpdateFestival(long id, Festival1 festival1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != festival1.Id)
            {
                return BadRequest();
            }

            db.Entry(festival1).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Festival1Exists(id))
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

        // POST: api/Festival1/CreateFestival
        [ResponseType(typeof(Festival1))]
        [HttpPost]
        public IHttpActionResult CreateFestival(Festival1 festival1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Festival1.Add(festival1);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = festival1.Id }, festival1);
        }

        // DELETE: api/Festival1/DeleteFestival/5
        [ResponseType(typeof(Festival1))]
        [HttpDelete]
        public IHttpActionResult DeleteFestival(long id)
        {
            Festival1 festival1 = db.Festival1.Find(id);
            if (festival1 == null)
            {
                return NotFound();
            }

            db.Festival1.Remove(festival1);
            db.SaveChanges();

            return Ok(festival1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Festival1Exists(long id)
        {
            return db.Festival1.Count(e => e.Id == id) > 0;
        }
    }
}