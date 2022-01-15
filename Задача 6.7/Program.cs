using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit, x;
            x = 0;
            limit = int.Parse(Console.ReadLine());
            while (limit > x)
            {
                Console.Write("{0} ", x);
                x++;
            }
        }
    }
}
