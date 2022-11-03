using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Yorum
    {
        [Key]
        public int id { get; set; }

        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorumlar { get; set; }
        public bool Cinsiyet { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blogs { get; set; }

    }
}