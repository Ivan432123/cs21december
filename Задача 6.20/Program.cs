using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, y, z, k;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            y = a + 10;
            z = b + 10;
            k = c + 10;
            

            while (a < y | b < z | c < k)
            {
                if (a == 10 | b == 10 | c == 10)
                {

                    Console.WriteLine("{0} {1} {2} Найдено", a, b, c);
                    a++;
                    b++;
                    c++;
                }

                else
                {

                    Console.WriteLine("{0} {1} {2}", a, b, c);
                    a++;
                    b++;
                    c++;
                }

                

                }
            }
        }

    }

        
    
