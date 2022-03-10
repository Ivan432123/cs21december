using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();


            // Проверка массива на пустой ввод от пользователя
            if (String.IsNullOrEmpty(data))
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }

            // Находим в необработанных данных data элементы разделённые ","
            String[] arr = data.Split(',');

            // Условия проверки длины массива заданные в if() и вывод на консоль
            if (arr.Length >= 6)
            {

                Console.WriteLine("Значение элемента на индексе 0 это " + arr[0]);
                Console.WriteLine("Значение элемента на индексе 2 это " + arr[2]);
                Console.WriteLine("Значение элемента на индексе 3 это " + arr[3]);
                Console.WriteLine("Значение элемента на индексе 5 это " + arr[5]);
                return;
             }

            if (arr.Length < 6 && arr.Length > 3)
            {
                Console.WriteLine("Значение элемента на индексе 0 это " + arr[0]);
                Console.WriteLine("Значение элемента на индексе 2 это " + arr[2]);
                Console.WriteLine("Значение элемента на индексе 3 это " + arr[3]);
                Console.WriteLine("Нет элемента на индексе 5");
                return;
            }

            if (arr.Length <= 3 && arr.Length > 2)
            {
                Console.WriteLine("Значение элемента на индексе 0 это " + arr[0]);
                Console.WriteLine("Значение элемента на индексе 2 это " + arr[2]);
                Console.WriteLine("Нет элемента на индексе 3");
                Console.WriteLine("Нет элемента на индексе 5");
                return;
            }

            if (arr.Length <= 2)
            {
                Console.WriteLine("Значение элемента на индексе 0 это " + arr[0]);
                Console.WriteLine("Нет элемента на индексе 2");
                Console.WriteLine("Нет элемента на индексе 3");
                Console.WriteLine("Нет элемента на индексе 5");
                return;
            }
           

            

            
        }
            
        }

        }
    
