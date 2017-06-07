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
    }
}
