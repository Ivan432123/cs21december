using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int R, T, d, m;
            R = int.Parse(Console.ReadLine());
            T = int.Parse(Console.ReadLine());
            d = 0;
            m = 0;

            if (R < d)
            {
                Console.WriteLine("Значение R должно быть неотрицательно");
                return;
            }
            

            if (T < m)
            {
                Console.WriteLine("Значение D должно быть неотрицательно");
                return;
            }
            


            while (R > d)
            {
                
                Console.Write("#", R);
                d++;
                
            }

            Console.WriteLine("\n");


            while (T > m)
           {
                
                
                Console.Write("#", T);
                m++;

            }
            
                
            }
        }
    }

