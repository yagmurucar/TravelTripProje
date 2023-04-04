﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");//Indexse yönlendirme

        }
        public ActionResult BlogGetir(int id)
        {
            var bl=c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
        public ActionResult BlogGuncelle(Blog b )
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama=b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorums.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorums.Find(id);
            c.Yorums.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");//Indexse yönlendirme

        }
        public ActionResult YorumGetir(int id)
        {
            var yrm = c.Yorums.Find(id);
            return View("YorumGetir", yrm);
        }
        public ActionResult YorumGuncelle(Yorum y)
        {
            var yrm = c.Yorums.Find(y.ID);
            yrm.KullainiciAdi = y.KullainiciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorumlar = y.Yorumlar;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}