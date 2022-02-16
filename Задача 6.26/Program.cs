using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = 0;

            if(x <= 0)
            {
                Console.WriteLine("Значение Х должно быть положительным");
            }
            
            while (y <= x)
            {
                y++;
                if (x % y == 0)
                {
                   
                    Console.Write("{0} ", y);
                    
                }
                

            }
        }
    }
}
