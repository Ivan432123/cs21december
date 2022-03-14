using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine(" ");
                return;
            }

            String[] arr = data.Split(' ');
            int a = 0;
            int i = 0;


            while (a < arr.Length)
            {

                while (i < a)
                {

                    Console.WriteLine("{0} {1}", arr[a], i);
                    i++;
                }
                a++;
            }

            // через for
            //for (a = 0; a < arr.Length; a++)
            //{
            //    for (i = 0; i < a; i++)
            //    {

            //    }
                
            //    Console.WriteLine("{0} {1}", arr[a], i);
            //}
            
                
            }
        }
    }

