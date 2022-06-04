using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Project
{
    public class BakeryProducts : Store
    {
        double quantity = 10;
        double prod_price = 3;
        string type = "bread";
        public BakeryProducts()
        { }

        public int bakerystock(int total, int ordered)
        {
            return total - ordered;

        }
        public override double TotalPrice()
        {
            return quantity * prod_price;
        }


    }
}
