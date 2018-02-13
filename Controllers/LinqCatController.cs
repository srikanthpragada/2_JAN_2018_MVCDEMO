using mvcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class LinqCatController : Controller
    {
       
        public ActionResult List()
        {
            InventoryContext ctx = new InventoryContext();
            return View(ctx.Categories);
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            InventoryContext ctx = new InventoryContext();
            var cat = (from c in ctx.Categories
                       where c.Code == id
                       select c).SingleOrDefault();

            if (cat == null)
                TempData.Add("Message","Sorry! Category Not Found!");
            else
            {
                ctx.Categories.DeleteOnSubmit(cat);
                ctx.SubmitChanges();
            }
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Add()
        {
            Category cat = new Category();
            return View(cat);
        }

        [HttpPost]
        public ActionResult Add(Category cat)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    InventoryContext ctx = new InventoryContext();
                    ctx.Categories.InsertOnSubmit(cat);
                    ctx.SubmitChanges();
                    ViewBag.Message = "Category has been added successfully!";
                }
                catch(Exception ex)
                {
                    HttpContext.Trace.Write("Error : " + ex.Message);
                    ViewBag.Message = "Sorry! Could not add category!";
                }
            }
            return View(cat);
        }
    }
}