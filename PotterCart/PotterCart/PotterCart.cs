using System.Collections.Generic;
using System.Linq;

namespace PotterCart
{
    /// <summary>
    /// 書店購物車
    /// </summary>
    public class PotterCart
    {
        /// <summary>
        /// 計算成交價
        /// </summary>
        /// <param name="books">書本集合</param>
        /// <returns>成交價</returns>
        public decimal CalculateDealPrice(List<Book> books)
        {
            return CalculateDiscount(books)
                .Sum(r => r.DealPrice);
        }

        /// <summary>
        /// 計算折扣
        /// </summary>
        /// <param name="books">書本集合</param>
        /// <returns></returns>
        private List<Book> CalculateDiscount(List<Book> books)
        {
            // 撈出沒算過折扣的
            var toCalBooks = books
                .Where(r => r.IsCalculated == false)
                .ToList();

            // 都計算過了 => 中止迴圈
            if (toCalBooks.Count == 0)
                return books;

            // 書本種類數
            var distinctNames = toCalBooks
                .Select(r => r.Name)    // 依書名判斷
                .Distinct()
                .ToList();

            // 依種類數算折扣比例
            var discountPercent =
                GetDiscountPercentByKinds(distinctNames.Count());

            // 得到 0 就代表沒得折了 => 中止迴圈
            if (discountPercent == 0)
                return books;

            foreach (var name in distinctNames)
            {
                // 找一本符合的
                var selectBook = toCalBooks
                    .FirstOrDefault(r => r.Name.Equals(name));
                // 塞折扣
                selectBook.DiscountPercent = discountPercent;
            }

            return CalculateDiscount(books);
        }

        /// <summary>
        /// 依購買種類數量計算折扣比例
        /// </summary>
        /// <param name="kinds">種類數量</param>
        /// <returns>折扣比例</returns>
        private decimal GetDiscountPercentByKinds(int kinds)
        {
            if (kinds <= 1)
                return 0;           // 1種 => 沒折
            if (kinds == 2)
                return 5;           // 2種 => 95折
            if (kinds == 3)
                return 10;          // 3種 => 90折
            if (kinds == 4)
                return 20;          // 4種 => 80折

            return 25;              // 5種以上 => 75折
        }
    }
}
