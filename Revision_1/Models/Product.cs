using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Revision_1.Models
{
    public partial class Product
    {
    
        public int Id { get; set; }
        public string Name { get; set; }    
        public Nullable<decimal> Price { get; set; }

        public virtual Brand Brand { get; set; }
      
    }
}