using Revision_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revision_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NavbaseContext dbCon = new NavbaseContext();
            List<Product> products = dbCon.Products.ToList();

            return View(products);

        }

    }
}