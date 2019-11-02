using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager {
    class Product {
        //declare public properties (instance variables)
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        //need to code a default constructor
        public Product() {

        }

        public Product(string c, string d, double p) {
            Code = c;
            Description = d;
            Price = p;
        }

        //parent class is super in java, but is base in c#
        public override string ToString() {
            return $"Product: code={Code}, desc={Description}, price={Price.ToString("C2")}";
        }
    }
}
