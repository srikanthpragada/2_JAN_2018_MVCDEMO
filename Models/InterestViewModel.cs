using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class InterestViewModel
    {
        [Range(1000, Double.MaxValue, ErrorMessage ="Minimum value must be 1000")]
        public double Amount { get; set; }

        [Range(5,50, ErrorMessage ="Valid interest rate is between 5 and 50")]
        public double Rate { get; set; }

        public double Interest { get; set; }
    }
}