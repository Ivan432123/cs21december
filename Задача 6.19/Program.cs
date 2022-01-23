using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            y = 10;
            z = 20;
           
            
            

            while (y <= z)
            {
                Console.WriteLine(y);
                y++;
            }
            x = int.Parse(Console.ReadLine());
            while (x >= y && x <= z)
            {
                Console.WriteLine("Найдено");
            }

            
        }
    }
}
