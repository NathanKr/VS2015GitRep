using MVC_With_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MVC_With_EF.Controllers.api
{
    public class BlogsController : ApiController
    {
        ApplicationDbContext m_db =
           new ApplicationDbContext();

        // /api/blogs
        [HttpGet]
        public IEnumerable<Blog> GetBlogs()
        {
            return m_db.Blogs;
        }




        [HttpGet]
        // GET /api/blogs/1
        public IHttpActionResult GetBlog(long id)
        {
            Blog blog = m_db.Blogs.SingleOrDefault(blg => blg.Id == id);

            if (blog == null)
            {
                return NotFound();
            }

            return Ok(blog);
        }

        // simple validation
        bool validationIsOk(string title , string description)
        {
            return !string.IsNullOrEmpty(title) &&
                   !string.IsNullOrEmpty(description);
        }

        // POST /api/blogs
        [HttpPost]
        public IHttpActionResult CreateBlog(Blog blog)
        {
            if ((blog != null) && 
                !validationIsOk(blog.Title, blog.Description))
            {
                return BadRequest();
            }

            
            m_db.Blogs.Add(blog);
            m_db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = blog.Id }, blog);
        }

        // PUT /api/blogs/4  -> update blog with id 4
        [HttpPut]
        public IHttpActionResult UpdateBlog(long id, Blog blg)
        {
            if ((blg != null) && 
                !validationIsOk(blg.Title, blg.Description)){
                return BadRequest();
            }

            if (id != blg.Id){return BadRequest();}

            Blog blog = m_db.Blogs.Find(blg.Id);
            if (blog == null){
                return NotFound();
            }

            blog.Title = blg.Title;
            blog.Description = blg.Description;
            m_db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE /api/blogs/4 -> delete blog with id 4
        [HttpDelete]
        public IHttpActionResult DeleteBlog(long id)
        {
            Blog blog = m_db.Blogs.Find(id);
            if (blog == null)
            {
                return NotFound();
            }

            m_db.Blogs.Remove(blog);
            m_db.SaveChanges();

            return Ok(blog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                m_db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
