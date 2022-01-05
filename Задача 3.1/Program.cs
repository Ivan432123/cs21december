using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double P = Convert.ToDouble(Console.ReadLine());
            double Q = Convert.ToDouble(Console.ReadLine());
            double R;
            
            if(P > Q)
            {
                R = P - Q;
                Console.WriteLine("Максимальное " + P + ", минимальное " + Q + ". Разница " + R + ".");
            }
            if(Q > P)
            {
                R = Q - P;
                Console.WriteLine("Максимальное " + Q + ", минимальное " + P + ". Разница " + R + ".");

            }
            

            
            
        }
    }
}
