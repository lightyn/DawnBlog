using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DawnBlog.DAL;
using DawnBlog.Models;

namespace DawnBlog.Controllers
{
    public class BlogPostCommentsController : Controller
    {
        private DB db = new DB();

        // GET: BlogPostComments
        public ActionResult Index()
        {
            return View(db.BlogPostComment.ToList());
        }

        // GET: BlogPostComments/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogPostComment blogPostComment = db.BlogPostComment.Find(id);
            if (blogPostComment == null)
            {
                return HttpNotFound();
            }
            return View(blogPostComment);
        }

        // GET: BlogPostComments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPostComments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BlogPostComment_Id,CommentBody,DateAdded")] BlogPostComment blogPostComment)
        {
            if (ModelState.IsValid)
            {
                db.BlogPostComment.Add(blogPostComment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blogPostComment);
        }

        // GET: BlogPostComments/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogPostComment blogPostComment = db.BlogPostComment.Find(id);
            if (blogPostComment == null)
            {
                return HttpNotFound();
            }
            return View(blogPostComment);
        }

        // POST: BlogPostComments/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BlogPostComment_Id,CommentBody,DateAdded")] BlogPostComment blogPostComment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blogPostComment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogPostComment);
        }

        // GET: BlogPostComments/Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogPostComment blogPostComment = db.BlogPostComment.Find(id);
            if (blogPostComment == null)
            {
                return HttpNotFound();
            }
            return View(blogPostComment);
        }

        // POST: BlogPostComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BlogPostComment blogPostComment = db.BlogPostComment.Find(id);
            db.BlogPostComment.Remove(blogPostComment);
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
