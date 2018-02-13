using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcdemo.Models
{
    [Table (Name ="categories")]
    public class Category
    {
        [Column (Name="catcode", IsPrimaryKey = true)]
        public string Code { get; set; }

        [Column (Name ="catdesc")]
        public string Description { get; set; }
    }
}
