using BlogsMVC_EF.Models;
using BlogsMVC_EF.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogsMVC_EF.Controllers
{
    public class BlogController : Controller
    {
        ApplicationDbContext m_db = new ApplicationDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Blog> blogs = m_db.Blogs;
            return View(blogs);
        }

        [HttpGet] public ActionResult Create()
        {
            Blog blog = null;

            return View(blog);
        }

        [HttpPost]
        public ActionResult Create(string title)
        {
            Blog blog = null;
            if (!string.IsNullOrEmpty(title))// simple validation
            {
                blog = new Blog { Title = title };
                m_db.Blogs.Add(blog);
                m_db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing){
                m_db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}