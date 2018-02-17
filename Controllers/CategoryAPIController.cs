using mvcdemo.Models.Ef;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;

namespace mvcdemo.Controllers
{
    public class CategoryAPIController : ApiController
    {

        //  Get CategoryAPI
        public  IEnumerable<Category>  Get()
        {
            var ctx = new InventoryContext();
            return ctx.Categories.ToList<Category>();

        }
        // Get CategoryAPI/id
        public Category Get(string id)
        {
            var ctx = new InventoryContext();
            var cat = ctx.Categories.Find(id);
            if (cat == null)
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);  // 404

            return cat;
        }

        // Delete   CategoryAPI/id
        [HttpDelete]
        public void Delete(string id)
        {
            var ctx = new InventoryContext();
            var cat = ctx.Categories.Find(id);
            if (cat == null)
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);  // 404

            ctx.Categories.Remove(cat);
            ctx.SaveChanges();
        }

        // Post   CategoryAPI
        [HttpPost]
        public void Post(Category cat)
        {
            var ctx = new InventoryContext();
            ctx.Categories.Add(cat);
            ctx.SaveChanges();
        }

        // Put   CategoryAPI/id
        [HttpPut]
        public void Put(string id, Category cat)
        {
            var ctx = new InventoryContext();
            var dbcat = ctx.Categories.Find(id);
            if (dbcat == null)
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);  // 404

            dbcat.Description = cat.Description;
            ctx.SaveChanges();
        }
    }
}
