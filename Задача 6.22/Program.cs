using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t, x;
            n = int.Parse(Console.ReadLine());
            t = 0;
            x = 0;
            while(n > t)
            {
                t++;
                Console.Write("!", n);

                if (x == 5)
                {
                    x -= 6;
                    Console.Write(" ");
                }
                x++;
                

            }
            



           /* if (n == 18)
            {
                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("! ");

                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("! "); 

                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("!");
                Console.Write("! ");

                Console.Write("!");
                Console.Write("!");
                Console.Write("!");

            }*/


        }
    }
}
