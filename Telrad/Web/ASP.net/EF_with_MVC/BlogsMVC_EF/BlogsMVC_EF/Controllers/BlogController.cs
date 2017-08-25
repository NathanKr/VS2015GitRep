using BlogsMVC_EF.Models;
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

        [HttpGet]
        public ActionResult Edit(long id)
        {
            Blog blog = m_db.Blogs.FirstOrDefault(blg => blg.Id == id);
            if (blog == null) { return HttpNotFound(); }
            return View(blog);
        }

        [HttpPost]
        public ActionResult Edit(long id, string title)
        {
            Blog blog = m_db.Blogs.FirstOrDefault(blg => blg.Id == id);
            if (blog == null) { return HttpNotFound(); }
            blog.Title = title; m_db.SaveChanges(); return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(long id)
        {
            Blog blog = m_db.Blogs.FirstOrDefault(blg => blg.Id == id);
            if (blog == null) { return HttpNotFound(); }
            m_db.Blogs.Remove(blog);
            m_db.SaveChanges();
            return RedirectToAction("Index");
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