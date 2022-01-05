using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            double height;
            double width;
            double area;
            Console.WriteLine("Задача 1976");
            Console.WriteLine("Введите высоту прямоугольника: ");
            temp = Console.ReadLine();
            height = Double.Parse(temp);
            Console.WriteLine("Введите ширину прямоугольника: ");
            width = Convert.ToDouble(Console.ReadLine());
            area = (height * width);
            Console.WriteLine("Площадь прямоугольника со сторонами " + height + " и " + width + " равна " + area);
        }
    }
}
