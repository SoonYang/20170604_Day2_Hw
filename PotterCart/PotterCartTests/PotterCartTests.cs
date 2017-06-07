using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterCart.Tests
{
    [TestClass()]
    public class PotterCartTests
    {
        [TestMethod()]
        public void 只買1本第1集_合計_100元()
        {
            var target = new PotterCart();
            var expected = 100m;

            var actual = target.CalculateFee();

            Assert.AreEqual(expected, actual);
        }
    }
}