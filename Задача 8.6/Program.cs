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
            int a = arr.Length;

            if(a <= 3)
            {
                Console.Write("{0} 0\n{1} 1\n{2} 2", arr[0], arr[1], arr[2]);
                Console.WriteLine();
            }
            
            if(a > 3 && a <= 5)
            {
                Console.Write("{0} 0\n{1} 1\n{2} 2\n{3} 3\n{4} 4", arr[0], arr[1], arr[2], arr[3], arr[4]);
                Console.WriteLine();
            }

            if(a > 5)
            {
                Console.Write("{0} 0\n{1} 1\n{2} 2\n{3} 3\n{4} 4\n{5} 5\n{6} 6\n{7} 7\n{8} 8\n{9} 9\n{10} 10\n{11} 11", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9], arr[10], arr[11]);
                Console.WriteLine();
            }
        }
    }
}
