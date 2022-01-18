using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit, x;
            x = 1;
            limit = int.Parse(Console.ReadLine());
            
            
                while (limit >= x)

                {
                    if(x % 2 == 0) // проверка числа на чётность
                    Console.Write("{0} ", x);
                    x++;

                

                
            }
            
        }
    }
}
    

