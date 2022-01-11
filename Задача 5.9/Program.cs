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
            double Xa, Ya, Xb, Yb, Delta_X, Delta_Y, r, angle, distance;
            
            Xa = Convert.ToDouble(Console.ReadLine());
            Ya = Convert.ToDouble(Console.ReadLine());
            Xb = Convert.ToDouble(Console.ReadLine());
            Yb = Convert.ToDouble(Console.ReadLine());
            
            // вычисление приращения координат
            Delta_X = Xb - Xa;
            Delta_Y = Yb - Ya;

            // румб линия
            r = Math.Atan(Delta_Y / Delta_X);

            // связь между румбами и дирекционными углами
            if (Delta_X >= 0 && Delta_Y > 0)
            {
                angle = r;
            }
            if (Delta_X < 0 && Delta_Y >= 0)
            {
                angle = 180 - r;
            }
            if (Delta_X <= 0 && Delta_Y < 0)
            {
                angle = 180 + r;
            }
            if(Delta_X > 0 && Delta_Y <= 0) 
            {
                angle = 360 - r;
            }

            distance = Math.Sqrt((Xb - Xa) + Math.Pow(2, 2) + (Yb - Ya) + Math.Pow(2, 2));
            Console.WriteLine("Горизонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, r);
        }
    }
}
