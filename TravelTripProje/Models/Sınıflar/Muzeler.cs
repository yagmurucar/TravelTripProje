using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Models.Sınıflar
{
    public class Muzeler
    {
        [Key]
        public int ID { get; set; }
        public string MuzelBaslik { get; set; }
        public string MuzeAciklama { get; set; }
        public string MuzeImage { get; set; }
    }
}