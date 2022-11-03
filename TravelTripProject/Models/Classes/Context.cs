using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Context : DbContext

    {

        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
    }
}