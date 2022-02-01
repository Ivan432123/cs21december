using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = a++;
            c = a;
            while (a <= b)
            {
                Console.WriteLine("{0}", c);
                a++;
                
            }
            c = a--;


            
                }
        }
    }
