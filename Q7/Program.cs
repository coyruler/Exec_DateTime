using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //根據不同時間, 傳回不同問安方式
            DateTime dt1 = DateTime.Now;
            int time = dt1.Hour;
            if (time < 12)
            {
                Console.WriteLine("早安");
            }
            else if (time > 18)
            {
                Console.WriteLine("晚安");
            }
            else
            {
                Console.WriteLine("午安");
            }

        }
    }
}
