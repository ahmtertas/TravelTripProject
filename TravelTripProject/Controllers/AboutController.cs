using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        Hakkimizda hakkimizda = new Hakkimizda();
        Context context = new Context();
        public ActionResult Index()
        {
            var about = context.Hakkimizdas.ToList();
            return View(about);
        }    

    }
}