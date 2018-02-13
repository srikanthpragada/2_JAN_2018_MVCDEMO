using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcdemo.Models
{
    class InventoryContext : DataContext
    {
        public InventoryContext() :
             base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {
        }

        public Table<Category> Categories
        {
            get
            {
                return GetTable<Category>();
            }
        }

    }
}
