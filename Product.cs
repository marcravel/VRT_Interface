using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRT_Interface
{
    internal class Product
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public double sell(double qty)
        {
            return this.Price * qty;
        }
    }
}
