using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class AdresBlog
    {

        [KeyAttribute]
        public int id { get; set; }

        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string AdresAcik { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }
    }
}