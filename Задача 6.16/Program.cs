using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if(a < b)
            {
                Console.WriteLine("От А до В");
            }
            if(a > b)
            {
                Console.WriteLine("От В до А");
            }
            if (a == b)
            {
                Console.WriteLine("Границы равны \n{0}", a);
                return;
            }
            while(a <= b)
            {
                Console.Write("{0} ", a);
                a++;
            }
            while(a >= b)
            {
                Console.Write("{0} ", b);
                b++;
            }
            

        }
    }
}
