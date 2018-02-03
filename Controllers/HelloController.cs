using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello  or Hello/Index 
        public ActionResult Index(string name)
        {
            ViewBag.Title = "Srikanth Technologies";
            ViewBag.Name = "World";
            if (name != null && name.Length > 0)
                ViewBag.Name = name;

            return View();
        }

        //  Hello/About 
        public ActionResult About()
        {
            return View();
        }
    }
}