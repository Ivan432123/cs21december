using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine("Предисловие");
            while (x <= 7) 
            {
                
                Console.WriteLine("Глава" + x);
               
                x += 1;
            }
            Console.WriteLine("Послесловие");

        }
    }
}
