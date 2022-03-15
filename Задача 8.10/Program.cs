using System;

namespace Задача_8._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            
            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Нет данных");
                return;
            }
            String[] arr = data.Split(' ');
            int i = 0;
           
            while (i < arr.Length)
            {
                Console.Write("{0} ", arr[i]);
                i++;
             
            }

        }
    }
}
