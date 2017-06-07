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
            // 折扣比例
            var discountPercent = 0m;

            // 書本種類數
            var distinctCount = books.Distinct().Count();


            if (distinctCount == 1)
                discountPercent = 0;        // 1種 => 沒折
            else if (distinctCount == 2)
                discountPercent = 5;        // 2種 => 95折
            else if (distinctCount == 3)
                discountPercent = 10;       // 3種 => 90折
            else if (distinctCount == 4)
                discountPercent = 20;       // 4種 => 80折
            else if (distinctCount == 5)
                discountPercent = 25;       // 5種 => 75折


            // 成交價 = 總原價 * 折後比例
            return books.Sum(r => r.Price) * (100 - discountPercent) / 100;
        }
    }
}
