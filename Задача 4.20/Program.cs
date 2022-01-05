using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Xt = Convert.ToInt32(Console.ReadLine());
            int Yt = Convert.ToInt32(Console.ReadLine());
            int Xn1 = Convert.ToInt32(Console.ReadLine());
            int Yn1 = Convert.ToInt32(Console.ReadLine());
            int Xn2 = Convert.ToInt32(Console.ReadLine());
            int Yn2 = Convert.ToInt32(Console.ReadLine());
            if (Xt < 0)
            {
                Console.WriteLine("Координата X должна быть неотрицательной");
            }
            if ((Xt - Xn1) / (Xn2 - Xn1) == (Yt - Yn1) / (Yn2 - Yn1))
            {
                Console.WriteLine("Точка принадлежит прямой");
            }
            
            if ((Xt - Xn1) / (Xn2 - Xn1) != (Yt - Yn1) / (Yn2 - Yn1))
                
                Console.WriteLine("Точка не принадлежит прямой");
        }
    }
}
