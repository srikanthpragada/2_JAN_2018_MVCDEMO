using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class CacheController : Controller
    {
        [OutputCache (Duration = 60, VaryByParam = "cat")]
        public string Index()
        {
            return DateTime.Now.ToLongTimeString();
        }


        public ActionResult List()
        {

            Dictionary<string, string> data =(Dictionary<string,string>) HttpContext.Cache["accounts"];

            if (data == null)
            {
                // obtain data 
                HttpContext.Cache.Insert("accounts", "Accounts Data Here", null, DateTime.Now.AddSeconds(60), TimeSpan.Zero);
                ViewBag.Message = "Cache Created!";
            }
            else
            {
                ViewBag.Message = "Using Cache!";
            }

            return View(data);

        }
    }
}