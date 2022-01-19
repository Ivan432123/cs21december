using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Значение А должно быть не больше значения В");
                return;
            }
            Console.Write("{ ");
            while(b >= a)
            {
                Console.Write("{0} ", b);
                b--;
            }
            Console.WriteLine("}");
        }
    }
}
