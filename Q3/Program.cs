using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //取得本月一日
            DateTime dt1 = DateTime.Today;
            string FirstDay = $"本月1號為 {dt1:MM}月1日";

            Console.WriteLine(FirstDay);

        }
    }
}
