using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double circleArea = Convert.ToDouble(Console.ReadLine());
            double squareArea = Convert.ToDouble(Console.ReadLine());
            double side_length = squareArea / 4;
            double radius = Math.Sqrt(circleArea / pi); 
        
           
            if (circleArea < squareArea && radius > side_length)
            {
                
                Console.WriteLine("Площадь круга {0:F4}, площадь квадрата равна {1:F4}\nПлощадь меньше, а не влез!\nКруг не поместится в квадрате", circleArea, squareArea);
            }
            if (circleArea < squareArea && radius < side_length)
            {
                Console.WriteLine("Площадь круга {0:F4}, площадь квадрата равна {1:F4}\nКруг уместится в квадрате", circleArea, squareArea);

            }
        }
    }
}
