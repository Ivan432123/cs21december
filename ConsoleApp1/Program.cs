using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            y = 10;
            z = 20;
            while (y <= z)
            {
                Console.WriteLine(y);
                y++;
            }
            x = int.Parse(Console.ReadLine());
            if (x == 10)
            {
                Console.WriteLine("{0}      Найдено", y);
            }





        }
            
        }
    }

    

