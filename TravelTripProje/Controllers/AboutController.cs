﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        public ActionResult Index()
        {
            //Contexte bulunan degerler yardımıyla hakkimizdas tablosunu çağırdık

            return View();
        }
    }
}