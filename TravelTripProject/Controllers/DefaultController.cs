using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var blogForImage = context.Blogs.ToList();
            return View(blogForImage);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult ConBot()
        {
            var degerler = context.Blogs.OrderByDescending(x => x.BlogId).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult RightPartial() 
        {
            var deger = context.Blogs.OrderBy(x => x.BlogId).Take(1).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Top10Partial() 
        {
            var deger = context.Blogs.Take(10).ToList();
            return PartialView(deger);
        }

        public PartialViewResult HomeLastPartial()
        {
            var deger = context.Blogs.Take(4).OrderBy(x=>x.BlogId).ToList();
            return PartialView(deger);
        }

        public PartialViewResult HomeLastPartialRight()
        {
            var deger = context.Blogs.Take(4).OrderByDescending(x=>x.BlogId).ToList();
            return PartialView(deger);
        }

    }
}