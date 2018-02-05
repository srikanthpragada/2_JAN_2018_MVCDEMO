using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class BankController : Controller
    {
        // GET: Bank
        public ActionResult Interest()
        {
            var model = new InterestViewModel();
            model.Rate = 12.5;
            return View(model);
        }

        [HttpPost]
        public ActionResult Interest(InterestViewModel model)
        {
            if (ModelState.IsValid)
            {
                 model.Interest = model.Amount * model.Rate / 100;
            }

            return View(model);
        }



    }
}