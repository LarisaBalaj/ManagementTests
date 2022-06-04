using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Project
{
    public class DairyProducts : Store
    {
        double quantity = 20;
        double prod_price = 3;
        string type = "almond milk";
        public DairyProducts()
        { }

        public int dairystock(int total, int ordered)
        {
            return total - ordered;

        }
        public override double TotalPrice()
        {
            return quantity * prod_price;
        }


    }
}
