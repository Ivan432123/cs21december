using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            y = 10;
            z = 20;

            x = int.Parse(Console.ReadLine());

            while (y <= z)
            {
                Console.WriteLine(y);
                y++;
                
                if (x >= y || x <= z)
                {
                    Console.Write(x);
                    Console.WriteLine(" Найдено");
                }

            }
            
            


            /* if (x == 10)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");
             }
             if (x == 11)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");
             }
             if (x == 12)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");
             }
             if (x == 13)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");
             }
             if (x == 14)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");
             }
             if (x == 15)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");
             }
             if (x == 16)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");
             }
             if (x == 17)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");
             }
             if (x == 18)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");
             }
             if (x == 19)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");
             }
             if (x == 20)
             {
                 Console.Write(x);
                 Console.WriteLine("Найдено");*/
        }
        }
    }

