﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class AnaSayfa
    {
        [Key]
        public int ID { get; set; }
        public String Baslik { get; set; }
        public String Aciklama { get; set; }
    }
}