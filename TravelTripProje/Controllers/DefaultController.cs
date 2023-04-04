using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        // GET: Default
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();//2 ye kdar sıarala 3 üncü blogu al defalta yerleştir
            return PartialView(degerler);
        }
        public PartialViewResult partial2()
        {
            var deger=c.Blogs.Where(x=>x.ID==1).ToList();
            return PartialView(deger);

        }
        public PartialViewResult partial3()
        {
            var deger = c.Blogs.ToList();
            return PartialView(deger);
        }
        public PartialViewResult partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult partial5()
        {
            var deger= c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(deger);
        }
    }
}