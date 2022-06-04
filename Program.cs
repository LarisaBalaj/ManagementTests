using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Store>()
            {
                new DairyProducts()
            };
            foreach (var s in products)
            {

                Console.WriteLine("total price of " + s.GetType().Name + " is " + s.TotalPrice());

            }

            Receip receip = new Receip();
            receip.ItemName = "Almond milk";
            receip.Price = 6.2;
        }

    }
}
