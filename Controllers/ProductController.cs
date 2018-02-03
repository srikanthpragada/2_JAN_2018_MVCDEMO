using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdemo.Models;

namespace mvcdemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Product p = new Product { Name = "iPhone X", Price = 80000 };
            p[0] = "More powerful front camera";
            p[1] = "Face recognition";
            // p[2] = "Wrireless charging";

            return View(p);
        }
    }
}