using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Oteller(/*nt Id*/)
        {
            ////var blogbul = c.Blogs.Where(x => x.ID == Id).ToList();
            //ViewBag.deger = Id;
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Restoranlar()
        {

            ViewBag.Message = "Your contact page.";
            return View();
        }
        //public ActionResult Oteller(int id)
        //{

        //    //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
        //    by.deger1 = c.Blogs.Where(x => x.ID == id).ToList();
        //    by.deger2 = c.Yorums.Where(x => x.ID == id).ToList();
        //    return View(by);
        //}

        public ActionResult Muzeler()
        {
            ViewBag.Message = "Müzeler";

            return View();
        }
    }
}