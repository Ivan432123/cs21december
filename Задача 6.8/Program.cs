using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i; 
            x = Convert.ToInt32(Console.ReadLine());
           
            while (x <= 32 && x >= 2)
            {
                Console.Write("{0} ", x);
                x = x + 3;
            }
            Console.WriteLine();

            x = 2;

            i = x - 40;
            while (i <= x)
            {

                Console.Write("{0} ", i);
                i = i + 4;
            }

            
            while(x <= 43 && x > 32)
            {
                Console.Write("{0} ", x);
                x = x + 3;
            }
            Console.WriteLine();
            x = 13;
            i = x - 30;
            while ( i <= x)
            {
                Console.Write("{0}", i);
                i = i + 4;
            }

            
            
            {

            }

        }
    }
}
