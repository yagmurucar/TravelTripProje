using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Models.Sınıflar
{
    public class Restoranlar
    {
        [Key]
        public int ID { get; set; }
        public string RestorantBaslik { get; set; }
        public string RestorantAciklama { get; set; }
        public string RestorantImage { get; set; }
    }
}