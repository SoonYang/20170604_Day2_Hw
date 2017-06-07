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

        public BookHarryPotter(int vol)
        {
            this.Vol = vol;
        }
    }
}
