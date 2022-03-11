using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                // Получаем необработанный массив от пользователя 
                String data = Console.ReadLine();

                // Проверяем пустой ли необработанный массив
                if (String.IsNullOrWhiteSpace(data))
                {
                    Console.WriteLine("Исходная строка пуста");
                    return;
                }

                String[] arr = data.Split(' ');
                int t = Int32.Parse(Console.ReadLine());

                // as df gh jk
                // 1
                if (arr.Length <= 4 && arr.Length > 2 && t > 0)
                {
                    Console.WriteLine("Элемент на индексе {0} содержит значение {1} ", t, arr[1]);
                    Console.WriteLine("Значение предыдущего элемента {0}", arr[0]);
                    Console.WriteLine("Значение следующего элемента {0}", arr[2]);

                }

                // a s d f g h j k
                // 3
                if (arr.Length > 4 && t > 0 && t < 7)
                {
                    Console.WriteLine("Элемент на индексе {0} содержит значение {1} ", t, arr[3]);
                    Console.WriteLine("Значение предыдущего элемента {0}", arr[2]);
                    Console.WriteLine("Значение следующего элемента {0}", arr[4]);
                    return;
                }

                // asdf ghjk
                // t == 0
                if (arr.Length <= 2 || arr.Length >= 4 && t == 0)
                {
                    Console.WriteLine("Элемент на индексе {0} содержит значение {1} ", t, arr[0]);
                    Console.WriteLine("Предыдущий элемент не существует");
                    Console.WriteLine("Значение следующего элемента {0}", arr[1]);
                    return;
                }

                // a s d f g h j k
                // t = 7 t = 3
                if (arr.Length >= 6 && t > 3)
                {
                    Console.WriteLine("Элемент на индексе {0} содержит значение {1}", t, arr[7]);
                    Console.WriteLine("Значение предыдущего элемента {0}", arr[6]);
                    Console.WriteLine("Следующий элемент не существует");
                }
                //if (arr.Length >= 8 && t > 0)
                //{
                //    Console.WriteLine("Элемент на индексе {0} содержит значение {1}", t, arr[7]);
                //    Console.WriteLine("Значение предыдущего элемента {0}", arr[6]);
                //    Console.WriteLine("Следующий элемент не существует");
                //}
                //if(arr.Length <= 4 && t == 3)
                //{
                //    Console.WriteLine("Элемент на индексе {0} содержит значение {1}", t, arr[3]);
                //    Console.WriteLine("Значение предыдущего элемента {0}", arr[2]);
                //    Console.WriteLine("Следующий элемент не существует");

                //}
                //if(arr.Length <= 2 && arr.Length > 1)
                //{
                //    Console.WriteLine("Элемент на индексе {0} содержит значение {1}", t, arr[1]);
                //    Console.WriteLine("Значение предыдущего элемента {0}", arr[0]);
                //    Console.WriteLine("Следующий элемент не существует");
                //}
                //if(arr.Length <= 1 && t == 0)
                //{
                //    Console.WriteLine("Элемент на индексе {0} содержит значение {1}", t, arr[0]);
                //    Console.WriteLine("Предыдущий элемент не существует");
                //    Console.WriteLine("Следующий элемент не существует");
                //}

            }
        }
    }
}