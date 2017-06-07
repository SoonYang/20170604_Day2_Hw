using System.Collections.Generic;

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
                return Price * (100 - _discountPercent) / 100;
            }
        }

        /// <summary>
        /// 是否已計算折扣
        /// </summary>
        public bool IsCalculated { get; private set; }

        private decimal _discountPercent;
        /// <summary>
        /// 折扣比例
        /// </summary>
        public decimal DiscountPercent
        {
            set
            {
                _discountPercent = value;
                IsCalculated = true;        // 改成已計算折扣
            }
        }

        /// <summary>
        /// 取得 Book list
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
