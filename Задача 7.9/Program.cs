using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h, a, b;
            string s;
            Console.Write("Введите символ ");
            s = Console.ReadLine();
            Console.Write("Введите чило ");
            h = int.Parse(Console.ReadLine());
            
            for (a = 0; a < h; a++)
            {
                for (b = -1; b < a; b++)
                {
                    
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }
    }
}
