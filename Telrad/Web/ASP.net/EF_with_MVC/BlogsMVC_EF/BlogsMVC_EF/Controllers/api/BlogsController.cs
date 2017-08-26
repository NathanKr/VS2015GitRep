using BlogsMVC_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BlogsMVC_EF.Controllers.api
{
    public class BlogsController : ApiController
    {
        ApplicationDbContext m_db = new ApplicationDbContext();

        // GET /api/blogs , return 200/OK if it is ok
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
        bool validationIsOk(string title)
        {
            return !string.IsNullOrEmpty(title);
        }

        // POST /api/blogs
        // title argument can be in request querystring or body 
        [HttpPost]
        public IHttpActionResult CreateBlog(string title)
        {
            if (!validationIsOk(title)) 
            {
                return BadRequest();
            }

            Blog blog = new Blog { Title = title };
            m_db.Blogs.Add(blog);
            m_db.SaveChanges();

            return  CreatedAtRoute("DefaultApi", new { id = blog.Id }, blog);
        }

        // PUT /api/blogs/4  -> update blog with id 4
        // title argument can be in request querystring or body 
        [HttpPut]
        public IHttpActionResult UpdateBlog(int id, string title)
        {
            if (!validationIsOk(title))
            {
                return BadRequest();
            }

            Blog blog = m_db.Blogs.SingleOrDefault(blg => blg.Id == id);

            if (blog == null)
            {
                return NotFound();
            }

            blog.Title = title;
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
