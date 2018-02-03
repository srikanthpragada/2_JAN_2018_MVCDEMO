using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcdemo.Models
{
    public class Product
    {
        private string[] features = new string[3];

        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Features
        {
            get
            {
                return features;
            }
        }
        // Indexer 
        public string this[int index]
        {
            get
            {
                return features[index];
            }
            set
            {
                features[index] = value;
            }
        }
    }
}