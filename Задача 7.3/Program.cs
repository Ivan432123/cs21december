using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w, a, b, c, d, e, f, g, h;
            Console.WriteLine("Введите значение W");
            w = int.Parse(Console.ReadLine());
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e = 0;
            f = 0;
            g = 0;
            h = 0;
            if(w <= -1 || w > 20)
            {
                Console.WriteLine("Значение W должно быть в интервале [0, 20]");
                return;
            }
            w -= 1;
            while (w >= a & w <= 20)
            {
                Console.Write("a", w);
                a++;
            }
            Console.WriteLine();
            
            while(w >= b & b <= 20)
            {
                Console.Write("b", w);
                b++;
            }
            Console.WriteLine();

            while(w >= c & c <= 20)
            {
                Console.Write("c", w);
                c++;
            }
            Console.WriteLine();

            while (w >= d & d <= 20)
            {
                Console.Write("d", w);
                d++;
            }
            Console.WriteLine();

            while (w >= e & w <= 20)
            {
                Console.Write("e", w);
                e++;
            }
            Console.WriteLine();

            while (w >= f & w <= 20)
            {
                Console.Write("f", w);
                f++;
            }
            Console.WriteLine();

            while (w >= g & w <= 20)
            {
                Console.Write("g", w);
                g++;
            }
            Console.WriteLine();

            while (w >= h & w <= 20)
            {
                Console.Write("h", w);
                h++;
            }
            Console.WriteLine();


        }
    }
}
