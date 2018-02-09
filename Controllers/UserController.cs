using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class UserController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
                return RedirectToAction(Request.QueryString["ReturnUrl"]);
            else
                ViewBag.Message = "Sorry! Invalid Login!";

            return View();
        }
    }
}