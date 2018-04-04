using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VidlyMaterialize.Models;

namespace VidlyMaterialize
{
    public class VidlyMaterializeContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public VidlyMaterializeContext() : base("VidlyMaterializeDB")
        {

        }
    }
}