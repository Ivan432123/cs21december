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
            int a, b, c, y, z, k, f;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            y = a + 10;
            z = b + 10;
            k = c + 10;
            f = 10;

            while (a < y && b < z && c < k)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
                a++;
                b++;
                c++;
                if (a == f || b == f || c == f)
                    {
                        Console.Write("{0} {1} {2}", a, b, c);
                        Console.WriteLine(" Найдено");
                    }
                }
            }
            
        }
    }

