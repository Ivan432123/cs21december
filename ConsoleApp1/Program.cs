using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            if (w < 0)
            {
                Console.WriteLine("Значение W быть неотрицательно!");
                return;
            }
            while (w > b && w >= h)
            {
                Console.Write(a, w);
                b++;


            }
            Console.WriteLine();

            while (w > c && w >= h)
            {
                Console.Write(a, w);
                c++;
            }
            Console.WriteLine();

            while (w > m && w >= h)
            {
                Console.Write(a, w);
                m++;
            }
            Console.WriteLine();


        }




















        }

    }
    




