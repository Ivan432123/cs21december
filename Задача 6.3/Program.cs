using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            int limit = 0;
            x = Console.ReadLine();
            Console.Write("\"");
            while (limit < 7)
            {
                Console.Write("{0}", x); 
                limit++;
            }
            Console.WriteLine("\"");
            
        
            


        }
    }
}
