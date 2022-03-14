using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] arr = data.Split(',');
            
            // Выводит массив в обратном порядке
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write("{0} ", arr[i]);
            }
            
            // через while
            //int i = 0;
            //while (i < arr.Length)
            //{
            //    Console.Write("{0} ", arr[i]);
            //    i++;
            //}
        }
    }
}
