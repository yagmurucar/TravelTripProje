using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;


namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogYorum by = new BlogYorum();
        Context c = new Context();
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            by.deger1 = c.Blogs.ToList();
            by.deger3 = c.Blogs.Take(3).ToList();
            return View(by);
        }
     
        public ActionResult BlogDetay  (int id)
        {
            
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.deger1=c.Blogs.Where(x => x.ID == id).ToList();
            by.deger2=c.Yorums.Where(x => x.ID == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int Id)
        {
            ViewBag.deger = Id;
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult YorumYap(Yorum y)
        {
            c.Yorums.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}