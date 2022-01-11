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

            // румб линия, дирекционный угол
            //r = Math.Atan(Delta_Y / Delta_X); //* 180 / Math.PI;

            //distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));

            // связь между румбами и дирекционными углами
            if (Delta_X >= 0 && Delta_Y > 0)
            {
                
                r = Math.Atan(Delta_Y / Delta_X) * 180 / Math.PI;
                angle = r;
                distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));
                Console.WriteLine("Горизонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);
            }
            if (Delta_X < 0 && Delta_Y >= 0)
            {
                r = Math.Atan(Delta_Y / Delta_X) * 180 / Math.PI;
                angle = 180 -(-r);
                distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));
                Console.WriteLine("Горизонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);
            }
            if (Delta_X <= 0 && Delta_Y < 0)
            {
                r = Math.Atan(Delta_Y / Delta_X) * 180 / Math.PI;
                angle = 180 + r;
                distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));
                Console.WriteLine("Горизонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);
            }
            if(Delta_X > 0 && Delta_Y <= 0) 
            {
                r = Math.Atan(Delta_Y / Delta_X) * 180 / Math.PI;
                angle = 360 - (-r);
                distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));
                Console.WriteLine("Горизонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);
            }
            
            //Горизонтальное проложение(расстояние между точками)
            //distance = Math.Sqrt(Math.Pow(Xb-Xa,2)+Math.Pow(Yb-Ya,2));
            //Console.WriteLine("Горизонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);
        }
    }
}
