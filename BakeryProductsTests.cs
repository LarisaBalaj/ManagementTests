using Microsoft.VisualStudio.TestTools.UnitTesting;
using Management_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_ProjectTests
{
    [TestClass]
    public class BakeryProductsTests
    {
        private int actual;
        [TestMethod()]
        public void BakeryProductsTest()
        {
            var expected = 4;
            var stock = new BakeryProducts();

            var actual = stock.bakerystock(10, 6);

            Assert.AreEqual(expected, actual);
        }


    }
}
