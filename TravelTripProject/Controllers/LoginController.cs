using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var forms = context.Admins.FirstOrDefault(x => x.KullaniciAdi == admin.KullaniciAdi
            && x.Sifre == admin.Sifre);
            if (forms != null)
            {
                FormsAuthentication.SetAuthCookie(forms.KullaniciAdi,false);
                Session["KullaniciAdi"] = forms.KullaniciAdi.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut() 
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Login");
        }
    }
}