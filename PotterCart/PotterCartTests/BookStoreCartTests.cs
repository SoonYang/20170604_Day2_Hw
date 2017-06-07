using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterCart.Tests
{
    [TestClass()]
    public class BookStoreCartTests
    {
        [TestMethod()]
        public void 只買1本第1集_合計_100元()
        {
            var target = new BookStoreCart();
            var expected = 100m;

            var books = new List<Book>();
            books.AddRange(Book.GetList(new BookHarryPotter(1), 1));

            var actual = target.CalculateDealPrice(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 買1本第1集_1本第2集_合計_190元()
        {
            var target = new BookStoreCart();
            var expected = 190m;

            var books = new List<Book>();
            books.AddRange(Book.GetList(new BookHarryPotter(1), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(2), 1));

            var actual = target.CalculateDealPrice(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 買1本第1集_1本第2集_1本第3集_合計_270元()
        {
            var target = new BookStoreCart();
            var expected = 270m;

            var books = new List<Book>();
            books.AddRange(Book.GetList(new BookHarryPotter(1), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(2), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(3), 1));

            var actual = target.CalculateDealPrice(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 買第1集_第2集_第3集_第4集_各1本_合計_320元()
        {
            var target = new BookStoreCart();
            var expected = 320m;

            var books = new List<Book>();
            books.AddRange(Book.GetList(new BookHarryPotter(1), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(2), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(3), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(4), 1));

            var actual = target.CalculateDealPrice(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 買第1集_第2集_第3集_第4集_第5集_各1本_合計_375元()
        {
            var target = new BookStoreCart();
            var expected = 375m;

            var books = new List<Book>();
            books.AddRange(Book.GetList(new BookHarryPotter(1), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(2), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(3), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(4), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(5), 1));

            var actual = target.CalculateDealPrice(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 買1本第1集_1本第2集_2本第3集_合計_370元()
        {
            var target = new BookStoreCart();
            var expected = 370m;

            var books = new List<Book>();
            books.AddRange(Book.GetList(new BookHarryPotter(1), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(2), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(3), 2));

            var actual = target.CalculateDealPrice(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 買1本第1集_2本第2集_2本第3集_合計_460元()
        {
            var target = new BookStoreCart();
            var expected = 460m;

            var books = new List<Book>();
            books.AddRange(Book.GetList(new BookHarryPotter(1), 1));
            books.AddRange(Book.GetList(new BookHarryPotter(2), 2));
            books.AddRange(Book.GetList(new BookHarryPotter(3), 2));

            var actual = target.CalculateDealPrice(books);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 買0本書_合計_0元()
        {
            var target = new BookStoreCart();
            var expected = 0m;
            var books = new List<Book>();

            var actual = target.CalculateDealPrice(books);

            Assert.AreEqual(expected, actual);
        }
    }
}