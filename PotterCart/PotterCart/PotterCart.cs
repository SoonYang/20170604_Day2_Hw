using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            while (true)
            {
                // 撈出沒折扣的
                var noDiscountBooks = books
                    .Where(r => r.DiscountPercent == 0)
                    .ToList();

                // 都有折扣了 => 中止迴圈
                if (noDiscountBooks.Count == 0) break;

                // 書本種類數
                var distinctNames = noDiscountBooks
                    .Select(r => r.Name)
                    .Distinct()
                    .ToList();

                // 依種類數算折扣比例
                var discountPercent =
                    GetDiscountPercentByKinds(distinctNames.Count());

                // 得到 0 就代表沒得折了 => 中止迴圈
                if (discountPercent == 0) break;

                foreach (var name in distinctNames)
                {
                    // 找一本符合的
                    var selectBook = noDiscountBooks
                        .FirstOrDefault(r => r.Name.Equals(name));
                    // 塞折扣
                    selectBook.DiscountPercent = discountPercent;
                    // 從未折清單移掉
                    noDiscountBooks.Remove(selectBook);
                }
            }

            // 統計(成交價)
            return books.Sum(r => r.DealPrice);
        }

        /// <summary>
        /// 依購買種類數量計算折扣比例
        /// </summary>
        /// <param name="kinds">種類數量</param>
        /// <returns>折扣比例</returns>
        private decimal GetDiscountPercentByKinds(int kinds)
        {
            if (kinds == 1)
                return 0;           // 1種 => 沒折
            else if (kinds == 2)
                return 5;           // 2種 => 95折
            else if (kinds == 3)
                return 10;          // 3種 => 90折
            else if (kinds == 4)
                return 20;          // 4種 => 80折
            else if (kinds >= 5)
                return 25;          // 5種以上 => 75折

            return 0;               // 其他沒定義，當沒折
        }
    }
}
