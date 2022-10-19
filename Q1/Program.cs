using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //計算三天後 DVD 應歸還時間
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = dt1.AddDays(3);
            string returnTime =$"DVD 應於 {dt2} 歸還" ;
            Console.WriteLine(returnTime);
        }
    }
}
