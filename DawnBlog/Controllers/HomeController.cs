using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DawnBlog.Models;
using DawnBlog.DAL;

namespace DawnBlog.Controllers
{
    public class HomeController : Controller
    {
        private DB db = new DB();

        public ActionResult Index()
        {
            return View(db.BlogPost.ToList());
        }

        //Redirect View action to BlogPost controller
        public ActionResult BlogPost(int? id)
        {
            return RedirectToAction("View","BlogPosts", new { area="", id=id });
        }

        //Redirect Create action to BlogPost controller
        public ActionResult NewPost()
        {
            return RedirectToAction("Create", "BlogPosts", new { area = "" });
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Chasing the Dawn";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }
    }
}