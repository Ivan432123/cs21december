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
            while(w > b)
            {
                Console.Write(a, w);
                b++;
            }
            Console.WriteLine();


            while (h > c)
            {
                Console.Write(a, h);
                c++;
            }
            Console.WriteLine();


        }
            }    
           
           

        }
 
