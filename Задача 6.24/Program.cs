using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            while(A > B | A < B)
            {
                Console.WriteLine("{0}___{1}", A, B);
                A++;
                B++;
            }
        }
    }
}
