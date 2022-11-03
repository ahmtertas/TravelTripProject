using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Home
    {
        [Key]
        public int HomeId { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}