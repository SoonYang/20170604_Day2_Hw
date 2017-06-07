using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterCart
{
    /// <summary>
    /// 哈利波特系列
    /// </summary>
    public class BookHarryPotter : Book
    {
        /// <summary>
        /// 集數
        /// </summary>
        public int Vol { get; private set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public override string Name
        {
            get
            {
                return $"Harry Potter {Vol}";
            }
        }

        /// <summary>
        /// 原價
        /// </summary>
        public override decimal Price { get { return 100m; } }

        /// <summary>
        /// 哈利波特系列
        /// </summary>
        /// <param name="vol">集數</param>
        public BookHarryPotter(int vol)
        {
            this.Vol = vol;
        }
    }
}
