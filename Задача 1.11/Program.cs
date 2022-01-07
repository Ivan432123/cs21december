using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("INSERT INTO points (x, y) VALUES ('$X', '$Y')");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INSERT INTO points (x, y) VALUES (" + "'" + x + "'" + ", " + "'" + y + "'" + ")");
        }
    }
}
