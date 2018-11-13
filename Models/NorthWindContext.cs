using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFrameworork.Models
{
    public class NorthWindContext : DbContext
    {
        public  NorthWindContext()
            :base("name=NorthWindConnection")
        {

        }
        public DbSet<Catagory> CatagoriesTable { get; set; }
        public DbSet<Product> productsTable { get; set; }
    }
}