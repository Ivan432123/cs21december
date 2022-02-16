using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, t, m, n;
            w = int.Parse(Console.ReadLine());
            t = 0;
            m = 0;
            n = 0;
            if(w == 1)
            {
                Console.WriteLine("+");
                Console.WriteLine("|");
                Console.WriteLine("+");
                return;
             }
            w -= 2;
            Console.Write("+");
            while (w > t)
                
            {
                Console.Write("-");
                t++;
           }
            Console.WriteLine("+");
            Console.Write("|");
            while (w > m)
            {
                
                Console.Write(".");
                m++;
            }
            Console.WriteLine("|");
            Console.Write("+");
            while (w > n)
            {
                
                Console.Write("-");
                n++;

            }
            Console.WriteLine("+");





        }
    }
}
