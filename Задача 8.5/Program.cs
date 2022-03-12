using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8._5
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

            String[] arr = data.Split(';');
            int a = arr.Length;
            
            if(a <= 3 && a > 1)
            {
                int ind = a - 2;
                Console.WriteLine("Длина массива: {0}, индекс: {1}, элемент: {2}", a, ind, arr[1]);
            }
            if(a == 4)
            {
                int ind = a - 3;
                Console.WriteLine("Длина массива: {0}, индекс: {1}, элемент: {2}", a, ind, arr[1]);
            }
            if(a > 4 && a <= 9)
            {
                int ind = a - 5;
                Console.WriteLine("Длина массива: {0}, индекс: {1}, элемент: {2}", a, ind, arr[4]);
            }
            if (a > 9)
            {
                int ind = a - 6;
                Console.WriteLine("Длина массива: {0}, индекс: {1}, элемент: {2}", a, ind, arr[4]);
            }
            if (a <= 1)
            {
                int ind = a - 1;
                Console.WriteLine("Длина массива: {0}, индекс: {1}, элемент: {2}", a, ind, arr[0]);
            }
        }
    }
}
