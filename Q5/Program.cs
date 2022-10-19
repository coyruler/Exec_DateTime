using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //列出指定年份的每一個星期日
            Console.WriteLine("請輸入年份(yyyy/mm/dd)");
            string input = Console.ReadLine();
            var dt1 = DateTime.Parse(input);
            DateTime dt2 = new DateTime(dt1.Year, 1, 1);
            DateTime dt3 = new DateTime();

            for (int i = 0; i < 6; i++)
            {
               dt3 = dt2.AddDays(i);
                if (dt3.DayOfWeek == 0)
                {
                    break;
                }                
            }

            Console.WriteLine($"{dt1.Year}年所有的星期日為:");

            for (int k = 0; k < 56; k++)
            {

                DateTime dt4 = dt3.AddDays(7 * k);
                if (dt4.Year == dt2.Year)
                {
                    string sundaysinyear = dt4.ToString("yyyy/MM/dd ddd");
                    Console.WriteLine(sundaysinyear);
                }
            }

            

            //if (dt2.DayOfWeek != 0)
            //{

            //    for (int i = 0; i < 6; i++)
            //    {
            //        dt3=dt2.AddDays(i);
            //    }
            //    for (int k = 0; k < 56; k++)
            //    {
            //        dt4 = dt3.AddDays(7*k);
            //        if (dt4.Year == dt1.Year)
            //        {
            //            string SundaysInYear = dt4.ToString("yyyy/MM/dd ddd");
            //            Console.WriteLine(SundaysInYear);
            //        }
            //    }

            //}
        }
    }
}
