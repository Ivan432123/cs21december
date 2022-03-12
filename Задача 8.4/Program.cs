using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }

            String[] arr = data.Split('#');
            int a = arr.Length;

            if(a > 3)
            {
                Console.WriteLine("Индекс третьего элемента с конца {0}\nЗначение этого элемента {1}", a - 3, arr[1]);
                return;
            }
            if(a > 2 && a <= 3)
            {
                Console.WriteLine("Индекс третьего элемента {0}\nЗначение этого элемента {1}", a - 3, arr[0]);
            }
                else
            {
                Console.WriteLine("Массив слишком маленький");
}
        }
    }
}
