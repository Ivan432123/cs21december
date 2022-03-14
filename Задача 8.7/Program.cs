using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] arr = data.Split(',');

            int i = 1;
            int name = 0;
            
            //while (name < arr.Length + 1)
            //{

            //    while (i <= name)
            //    {

            //        Console.WriteLine("Глава {0} {1}", i, arr[name - 1]);
            //        i++;
            //    }
            //    name++;
            //}

            // Через for
            for (name = 0; name < arr.Length; name++)
            {
                for (i = 1; i <= name; i++)
                {

                }
                Console.WriteLine("Глава {0} {1} ", i, arr[name]);
            }

            //if(a <= 5)
            //{
            //    Console.WriteLine("Глава 1 {0}\nГлава 2 {1}\nГлава 3 {2}\nГлава 4 {3}\nГлава 5 {4}", arr[0], arr[1], arr[2], arr[3], arr[4]);
            //}




        }
    }
}
