using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcdemo.Models.Ef
{
    [Table("categories")]
    public class Category
    {
        [Column("catcode")]
        [Key]
        public string Code { get; set; }

        [Column("catdesc")]
        public string Description { get; set; }
    }
}