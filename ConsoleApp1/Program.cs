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
            int A, B;
            
            A = int.Parse(Console.ReadLine());
            B = A + 10;
            while (A < B)
            {

                Console.WriteLine(A + "\n---");
                A += 1;
            }
            




        }
            
        }
    }

    

