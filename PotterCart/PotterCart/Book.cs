using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterCart
{
    /// <summary>
    /// 書
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 名稱
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        public virtual decimal Price { get; set; }

        /// <summary>
        /// Get Book list.
        /// </summary>
        /// <param name="book">書本</param>
        /// <param name="count">數量</param>
        /// <returns></returns>
        public static List<Book> GetList(Book book, int count)
        {
            var list = new List<Book>();
            list.AddRange(Enumerable.Repeat(book, count));

            return list;
        }
    }
}
