using Revision_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Revision_1.ApiControllers
{
   // [Route("api/brands")]
    public class BrandsController : ApiController
    {
        
        public List<Brand> Get()
        {
            NavbaseContext db = new NavbaseContext();
            List<Brand> brands= db.Brands.ToList(); 
             return brands;

        }
    }
}
