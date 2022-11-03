using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Hakkimizda
    {
        [Key]
        public int id { get; set; }

        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}