using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        //計算圖書下個月歸還時間
        static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = dt1.AddMonths(1);
            string returnTime = $"圖書請於下個月 {dt2:yyyy/MM/dd} 歸還";
            Console.WriteLine(returnTime);
        }
    }
}
