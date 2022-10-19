using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //取得本月最後一天
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = dt1.AddMonths(1);
            DateTime dt3 = new DateTime(dt2.Year, dt2.Month ,1 );
            DateTime dt4 = dt3.AddDays(-1);

            string LastDayInMonth = $"{dt4:yyyy/MM/dd}";



            Console.WriteLine("本月最後一天為:"+LastDayInMonth);
        }
    }
}
