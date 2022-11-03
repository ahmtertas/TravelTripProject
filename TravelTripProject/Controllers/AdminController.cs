using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            if (Request.Files.Count > 0)
            {
                Guid guid = System.Guid.NewGuid();
                
                string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/images/" + guid.ToString() +"." + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                blog.BlogImage = "/images/" + guid.ToString() + "." + uzanti;
            }

            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var currentBlog = context.Blogs.Find(id);
            context.Blogs.Remove(currentBlog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetBlog(int id)
        {
            var currentBlog = context.Blogs.Find(id);
            return View("GetBlog", currentBlog);
        }

        public ActionResult EditBlog(Blog blog)
        {
            var editBlog = context.Blogs.Find(blog.BlogId);
            editBlog.Aciklama = blog.Aciklama;
            editBlog.Tarih = blog.Tarih;
            editBlog.BlogOzet = blog.BlogOzet;
            editBlog.BlogImage = blog.BlogImage;
            editBlog.Baslik = blog.Baslik;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CommentList() 
        {
            var comment = context.Yorums.ToList();
            return View(comment);
        }

        public ActionResult DeleteComment(int id)
        {
            var currentComment = context.Yorums.Find(id);
            context.Yorums.Remove(currentComment);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }

    }
}