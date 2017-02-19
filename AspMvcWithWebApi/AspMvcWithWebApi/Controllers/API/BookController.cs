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
using AspMvcWithWebApi.Models;

namespace AspMvcWithWebApi.Controllers.API
{
    public class BookController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        /*
          added by Nathan 9/2/17 
          
            GET: api/Book/FindBookWithMaxPages

            use Routing according to "ActionApi" - "api/{controller}/{action}/{id}"

            attribute HttpGet can be removed because 
        */
        [HttpGet]  
        public IQueryable<Book> FindBooksWithMaxPages()
        {
            int nMaxPagNum = db.Books.Max(book => book.PagesNum);
            return db.Books.Where(book => book.PagesNum == nMaxPagNum); 
        }



        // GET: api/Book
        // [HttpGet] -> no need to use because of convention : action name start with Get
        public IQueryable<Book> GetBooks()
        {
            return db.Books;
        }

        // GET: api/Book/5
        // [HttpGet] -> no need to use because of convention : action name start with Get
        [ResponseType(typeof(Book))]
        public IHttpActionResult GetBook(long id)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        // PUT: api/Book/5
        // [HttpPut] -> no need to use because of convention : action name start with Put
        // Update book
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBook(long id, Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != book.Id)
            {
                return BadRequest();
            }

            db.Entry(book).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
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

        // POST: api/Book
        // [HttpPost] -> no need to use because of convention : action name start with Post
        // Create book
        [ResponseType(typeof(Book))]
        public IHttpActionResult PostBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Books.Add(book);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = book.Id }, book);
        }

        // DELETE: api/Book/5
        // [HttpDelete] -> no need to use because of convention : action name start with Delete
        [ResponseType(typeof(Book))]
        public IHttpActionResult DeleteBook(long id)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            db.Books.Remove(book);
            db.SaveChanges();

            return Ok(book);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookExists(long id)
        {
            return db.Books.Count(e => e.Id == id) > 0;
        }
    }
}