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
            int A, N;
            N = int.Parse(Console.ReadLine());
            A = 0;
            
            if (N < 0)
            {
                Console.WriteLine("Значение N должно быть неотрицательным");
            }

            while (N > A)
            {
                A++;
                Console.Write("#", N);

                if (A == 19)
                {
                    

                    Console.Write("#\n", N);
                    
                    A++;
                    
                }
                







            }
        }
    }
}
