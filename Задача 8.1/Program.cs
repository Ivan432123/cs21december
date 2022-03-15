using System;


namespace Задача_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем необработанный массив от пользователя 
            String data = Console.ReadLine();

            // Проверяем пустой ли необработанный массив
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Исходная строка пуста");
                return;
            }

           
            // Находим в необработанных данных data фрагменты разделённые пробелом 
            // Каждый найденный фрагмент это отдельный элемент массива arr  
            String[] arr = data.Split(' ');
            int a = Int32.Parse(Console.ReadLine());

            
            if (a > arr.Length || a < 0)
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
