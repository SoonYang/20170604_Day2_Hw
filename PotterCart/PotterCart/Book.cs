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
        /// 成交價
        /// </summary>
        public decimal DealPrice
        {
            get
            {
                return Price * (100 - DiscountPercent) / 100;
            }
        }

        /// <summary>
        /// 折扣比例
        /// </summary>
        public decimal DiscountPercent { get; set; }

        /// <summary>
        /// Get Book list.
        /// </summary>
        /// <param name="book">書本</param>
        /// <param name="count">數量</param>
        /// <returns></returns>
        public static List<Book> GetList(Book book, int count)
        {
            var list = new List<Book>();

            for (int i = 0; i < count; i++)
            {
                list.Add(book.MemberwiseClone() as Book);
            }

            return list;
        }
    }
}
