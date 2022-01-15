using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v, i, p;
            i = 1;
            v = int.Parse(Console.ReadLine());
            Console.WriteLine("Таблица умножения на {0}", v);
            while (i <= 9)
            {
                p = i * v;
                Console.WriteLine("{0} x {1} = {2}", i, v, p);
                i++;

            }
        }
    }
}
