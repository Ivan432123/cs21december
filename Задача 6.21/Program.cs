﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c, d, m;
            m = 0;
            n = int.Parse(Console.ReadLine());
            
            a = 0;

           /* if (a == 3)
            {
                a -= 3;


                Console.WriteLine("{0} - {1}", m, a);
                m++;
                a++;
                Console.WriteLine("{0} - {1}", m, a);
                m++;
                a++;
                Console.WriteLine("{0} - {1} ", m, a);
                m++;
                a++;
                Console.WriteLine("{0} - {1} ", m, a);
                m++;
                a++;
                Console.WriteLine("{0} - {1}", m, a);
                m++;
                a++;
                Console.WriteLine("{0} - {1}", m, a);
                m++;
                a++;
                Console.WriteLine("{0} - {1}", m, a);
                m++;
                a++;
                Console.WriteLine("{0} - {1}", m, a);
                m++;
                a++;

            }*/


             while(m <= n)
             {
                if (a == 4)
                {
                    a-=4;
                }

                    Console.WriteLine("{0} - {1}", m, a);
                    m++;
                    a++;
                
             }
             if (n < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
            }

        }
    }
}
