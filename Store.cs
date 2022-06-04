using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Project
{
  public abstract  class Store
    {
        protected double prod_price;
        protected double quantity;

        public  Store()
        { }

        public Store(double p)
        {
            this.prod_price = p;
        }

        public abstract double TotalPrice();
    }
}
