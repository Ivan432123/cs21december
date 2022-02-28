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
            int w, h, b, c;
            Console.Write("Введите символ: ");
            string a = Console.ReadLine();

            Console.Write("Введите ширину прямойгольника: ");
            w = int.Parse(Console.ReadLine());

            Console.Write("Введите высоту прямоугольника: ");
            h = int.Parse(Console.ReadLine());

            
            if (w < 0)
            {
                Console.WriteLine("Значение W быть неотрицательно!");
                return;
            }
            for(b = 0; b < h; b++)
            {
                for(c = 0; c < w; c++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }

           





        }
            }    
           
           

        }
 
