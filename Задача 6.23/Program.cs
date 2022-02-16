using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, N, T;
            N = int.Parse(Console.ReadLine());
            A = 0;
            T = 0;
            
            if (N < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
            }

            while (N > T)
            {
                T++;
                Console.Write("#", N);

                if (A == 19)
                {
                    A = 0;

                    Console.Write("#\n");
                    
                   
                    
                }
                A++;








            }
        }
    }
}
