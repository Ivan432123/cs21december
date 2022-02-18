using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, c, d, M;
            A = int.Parse(Console.ReadLine()); 
            B = int.Parse(Console.ReadLine());
            c = 0;
            d = 0;
            A -= 1;
            if (B < A)
            {
                Console.WriteLine("Количество символов во второй строке должно быть неотрицательным");
            }
           
            while (A >= c)
            {
                Console.Write("*", A);
                c++;
            }
            Console.WriteLine();

            M = A + B;
            while (M >= d)
            {
                
                Console.Write("*", M);
                d++;
            }
        }
    }
}
