using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Revision_1.Models
{
    public class NavbaseContext:DbContext
    {
        public NavbaseContext() : base("TinkuConnString") { }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }    
    }
}