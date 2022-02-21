using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w, a, b, c, d, e, f, g, h, i, y;
            w = int.Parse(Console.ReadLine());
           
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e = 0;
            f = 0;
            g = 0;
            h = 0;
            i = 0;
            y = 0;

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

            while (w > c && w <= 20)
            {
                Console.Write("2", w);
                c++;
            }
            Console.WriteLine();

            while (w > d && w <= 20)
            {
                Console.Write("3", w);
                d++;
            }
            Console.WriteLine();

            while (w > e && w <= 20)
            {
                Console.Write("4", w);
                e++;
            }
            Console.WriteLine();

            while (w > f && w <= 20)
            {
                Console.Write("5", w);
                f++;
            }
            Console.WriteLine();

            while (w > g && w <= 20)
            {
                Console.Write("6", w);
                g++;
            }
            Console.WriteLine();

            while (w > h && w <= 20)
            {
                Console.Write("7", w);
                h++;
            }
            Console.WriteLine();

            while (w > i && w <= 20)
            {
                Console.Write("8", w);
                i++;
            }
            Console.WriteLine();

            while (w > y && w <= 20)
            {
                Console.Write("9", w);
                y++;
            }
            Console.WriteLine();


        }
    }
}
