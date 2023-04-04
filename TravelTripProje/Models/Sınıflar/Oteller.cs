using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Models.Sınıflar
{
    public class Oteller
    {
        [Key]
        public int ID { get; set; }
        public string OtelBaslik { get; set; }
        public string OtelAciklama { get; set; }
        public string OtelImage { get; set; }
    }
}