using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Admin
    {

        [Key]
        public int AdminId { get; set; }

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}