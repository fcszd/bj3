using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double JD = 2461146.5;
            double a = Math.Floor(Convert.ToDouble(JD + 0.5));
            double b = a + 1537;
            double c = Math.Floor(Convert.ToDouble((b - 122.1) / 365.25));
            double d = Math.Floor(Convert.ToDouble(365.25 * c));
            double e = Math.Floor(Convert.ToDouble((b - d) / 30.600));
            double i = JD + 0.5 - Math.Floor(Convert.ToDouble(JD + 0.5));
            double D = b - d - Math.Floor(Convert.ToDouble(30.6001 * e)) + i;
            double M = e - 12 * Math.Floor(Convert.ToDouble(e / 14));
            double Y = c - 4715 - Math.Floor(Convert.ToDouble((7 + M) / 10));
            Console.WriteLine("Y={0};M={1};D={2}", Y, M, D);
            Console.ReadKey();
        }
    }
}
