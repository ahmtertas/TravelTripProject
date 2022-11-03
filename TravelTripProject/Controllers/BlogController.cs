using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        BlogYorum blogYorum = new BlogYorum();
        public ActionResult Index()
        {
            blogYorum.Blog = context.Blogs.ToList();
            blogYorum.Blog2 = context.Blogs.ToList().OrderByDescending(y => y.BlogId).Take(3);
            blogYorum.Yorum = context.Yorums.Take(3).ToList().OrderByDescending(y => y.BlogId);
            return View(blogYorum);
        }

        public ActionResult BlogDetay(int id)
        {

            blogYorum.Blog = context.Blogs.Where(x => x.BlogId == id).ToList();
            blogYorum.Yorum = context.Yorums.Where(x => x.BlogId == id).ToList();
            return View(blogYorum);
        }

        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            ViewBag.blogId = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Comment(Yorum yorum)
        {
            context.Yorums.Add(yorum);
            context.SaveChanges();
            return PartialView();
        }

    }
}