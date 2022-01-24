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
            int x, y, z; 
            x = Convert.ToInt32(Console.ReadLine());

            y = x + 30;
            
            while (x <= y)
                
            {
                
                Console.Write("{0} ", x);
                x += 3;
                
            }
            Console.WriteLine("\n");
            x = Convert.ToInt32(Console.ReadLine());
            y = x - 40;
            while (x >= y)
            {
                
                Console.Write("{0} ", y);
                
                y += 4;
            }

            
          
           

            
            
            {

            }

        }
    }
}
