using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcdemo.Models.Ef
{
    public class InventoryContext : DbContext
    {
        public  InventoryContext() :
            base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {

        }

        public virtual DbSet<Category>  Categories { get; set; }


    }
}