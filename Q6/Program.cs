using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //根據日期, 傳回今天是本月的上旬, 中旬或下旬
            DateTime dt1 = DateTime.Now;
            int month = dt1.Month;
            if(month<10)
            {
                Console.WriteLine($"今天是{dt1.Month}月的上旬");
            }
            else if (month > 20)
            {
                Console.WriteLine($"今天是月{dt1.Month}月的下旬");
            }
            else
            {
                Console.WriteLine($"今天是月{dt1.Month}月的中旬");
            }
        }
    }
}
