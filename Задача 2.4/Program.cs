using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double aDeg = Convert.ToDouble(Console.ReadLine());
            double aRad = (aDeg * pi / 180);
            Console.WriteLine("{0:F4}", aRad);
        }
    }
}
