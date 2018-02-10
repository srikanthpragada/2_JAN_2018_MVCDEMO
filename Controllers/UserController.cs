using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mvcdemo.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            Session.Add("ReturnUrl", Request.QueryString["ReturnUrl"]);
            return View();

        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                FormsAuthentication.SetAuthCookie("admin", false);
                return  RedirectToAction(".." + Session["ReturnUrl"].ToString ()); 
            }
            else
                ViewBag.Message = "Sorry! Invalid Login!";

            return View();
        }
    }
}