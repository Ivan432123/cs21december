using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Xa, Ya, Xb, Yb, X, Y, r;
            
            Xa = Convert.ToDouble(Console.ReadLine());
            Ya = Convert.ToDouble(Console.ReadLine());
            Xb = Convert.ToDouble(Console.ReadLine());
            Yb = Convert.ToDouble(Console.ReadLine());
            X = Xb - Xa;
            Y = Yb - Ya;
            

            r = Math.Atan(Y / X);
            Console.WriteLine(r);
        }
    }
}
