using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  A;
            
            A = int.Parse(Console.ReadLine());
            while(A <= 17 && A >=5)
             {
                
                 Console.WriteLine(A + "\n---");
                 A+=1;
             }
            Console.WriteLine();
            while(A <= 4)
            {
                Console.WriteLine(A + "\n---");
                A += 1;
            }
            while(A <= 704 && A >= 695)
            {
                Console.WriteLine(A + "\n---");
                A += 1;
            }
            
            
            /*Console.WriteLine("---");
            A++;
            Console.WriteLine(A + "\n---");
            A++;
            Console.WriteLine(A + "\n---");
            A++;
            Console.WriteLine(A + "\n---");
            A++;
            Console.WriteLine(A + "\n---");
            A++;
            Console.WriteLine(A + "\n---");
            A++;
            Console.WriteLine(A + "\n---");
            A++;
            Console.WriteLine(A + "\n---");
            A++;
            Console.WriteLine(A + "\n---");
            A++;
            Console.WriteLine(A + "\n---");
            A++;*/
            
            
        }
    }
}
