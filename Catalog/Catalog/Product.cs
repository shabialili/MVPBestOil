using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class Product
    {
        public string Product_Name { get; set; }
        public string Country { get; set; }
        public double Cost { get; set; }


        public override string ToString()
        {
            return $"{Product_Name}   {Country}   {Cost}" ;
        }
    }
}
