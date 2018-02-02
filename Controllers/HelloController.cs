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
        public ActionResult Index()
        {
            ViewBag.Title = "Srikanth Technologies";
            return View();
        }

        //  Hello/About 
        public ActionResult About()
        {
            return View();
        }
    }
}