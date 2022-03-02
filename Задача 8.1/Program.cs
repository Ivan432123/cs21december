using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }

           

            String[] arr = data.Split(' ');
            int a = Int32.Parse(Console.ReadLine());

            if (a > arr.Length || a == 3)
            {

                Console.WriteLine("Число А должно быть в интервале " + arr.Length);
                return;
            }

            if (a < arr.Length || a < 0)
            {

                Console.WriteLine("Число А должно быть в интервале " + arr.Length);
                return;
            }

            Console.WriteLine("В массиве длиной " + arr.Length);
            Console.WriteLine("на индексе " + a);
            Console.WriteLine("находится элемент со значением " + arr[a]);

            
        }
    }
}
