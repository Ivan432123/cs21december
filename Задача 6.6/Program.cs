using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());

            if (x <= 2)
                while (x <= 32)
                {

                    Console.Write("{0} ", x);
                    x += 3;
                }
            if (x <= 4)
                while (x <= 34)
                {
                    Console.Write("{0} ", x);
                    x += 3;
                }
            if (x < 0)
            {
                while (x <= 24)
                {
                    Console.Write("{0} ", x);
                    x += 3;
                }
            if (x >= 1000)
            {
                while (x <= 1030)
                {
                    Console.Write("{0} ", x);
                    x += 3;
                }



                }
            }
        }
    }
}
