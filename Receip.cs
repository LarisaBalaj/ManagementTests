using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Project
{
    class Receip
    {
         string item;
        double price;

        public string ItemName
        {
            get { return item; }
            set
            {
                item = value;
                Console.WriteLine("You ordered :   " + item);
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                Console.WriteLine("Your order cost : " + price);
            }
        }
    }
}
