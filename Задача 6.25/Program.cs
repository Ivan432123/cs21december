using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = 30;
            
            while (y <= 40)
            {

               
                if (x == y)
                {
                    Console.WriteLine("{0}+", y);
                }
                else
                {
                    Console.WriteLine("{0}-", y);
                }
                y++;
            }

        }
    }
}
