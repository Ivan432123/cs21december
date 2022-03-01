using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w, a, b, c, d, e, f, g, h, i, y;
            w = int.Parse(Console.ReadLine());

            a = 0;
            b = 0;
            

            if (w <= -1 || w > 20)
            {
                Console.WriteLine("Значение W должно быть в интервале [0, 20]");
                return;
            }
            while (w > a && w <= 20)
            {
                Console.Write("0", w);
                a++;
            }
            Console.WriteLine();

            while (w > b && w <= 20)
            {
                Console.Write("1", w);
                b++;
            }
            Console.WriteLine();
        }
    }
}
