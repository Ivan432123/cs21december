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

            
            Xa = double.Parse(Console.ReadLine());
            Ya = double.Parse(Console.ReadLine());
            Xb = double.Parse(Console.ReadLine());
            Yb = double.Parse(Console.ReadLine());

            // Вычисление приращения координат
            Delta_X = Xb - Xa;
            Delta_Y = Yb - Ya;

            // Дирекционый угол (методы класса Math).  Math.Atan(): возвращает арктангенс. Math.PI возвращает число пи(3.14) 
            r = Math.Atan(Delta_Y / Delta_X) * 180 / Math.PI;

            // Горизонтальное проложение(расстояние между точками). Math.Sqrt: возвращает квадратный корень
            // Pow(double A, double B): возвращает число A, возведенное в степень B.
            distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));

            // связь между румбами и дирекционными углами
            if (Delta_X >= 0 && Delta_Y > 0)

            {
                angle = Math.Abs(r);     // Math.Abs(-2) = 2 (возвращает положительное число из отрицательного)

                Console.WriteLine("Угол 1 четверти\nГоризонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);
            
            }

            if (Delta_X < 0 && Delta_Y >= 0)

            {
                angle = 180 - Math.Abs(r);
                
                Console.WriteLine("Угол 2 четверти\nГоризонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);
            
            }
            
            if (Delta_X <= 0 && Delta_Y < 0 ) 
            
            {
                 angle = 180 + Math.Abs(r);
                  
                 Console.WriteLine("Угол 3 четверти\nГоризонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);
            
            }

            if (Delta_X > 0 && Delta_Y <= 0)

            {
                 angle = 360 - Math.Abs(r);
                    
                 Console.WriteLine("Угол в 4 четверти\nГоризонтальное проложение {0:F4}\nДирекционный угол {1:F4}", distance, angle);
                
            }



            }
        }
    }

