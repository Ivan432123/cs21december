using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w, h, b, c, m;
            Console.Write("Введите символ: ");
            string a = Console.ReadLine();

            Console.Write("Введите ширину прямойгольника: ");
            w = int.Parse(Console.ReadLine());

            Console.Write("Введите высоту прямоугольника: ");
            h = int.Parse(Console.ReadLine());

            b = 0;
            c = 0;
            m = 0;
            w--;
            while(w > b)
            {
                Console.Write(" цикл 1 " + a, w);
                b++;
               
            }
            while(h > c)
            {
                Console.WriteLine(" цикл 2 " + a, h);
                c++;

                while (h > m)
                {
                    Console.Write(" цикл 3 " + a, m);
                    m++;
                }
            }
           

        }
    }
}
