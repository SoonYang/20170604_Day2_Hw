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

            var actual = target.CalculateDealPrice(
                new List<Book>
                {
                    new BookHarryPotter(1),
                });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 買1本第1集_1本第2集_合計_190元()
        {
            var target = new PotterCart();
            var expected = 190m;

            var actual = target.CalculateDealPrice(
                new List<Book>
                {
                    new BookHarryPotter(1),
                    new BookHarryPotter(2),
                });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 買1本第1集_1本第2集_1本第3集_合計_270元()
        {
            var target = new PotterCart();
            var expected = 270m;

            var actual = target.CalculateDealPrice(
                new List<Book>
                {
                    new BookHarryPotter(1),
                    new BookHarryPotter(2),
                    new BookHarryPotter(3),
                });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 買第1集_第2集_第3集_第四集_各1本_合計_320元()
        {
            Assert.Fail();
        }
    }
}