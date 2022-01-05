using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string ID;
            string text;
            Console.WriteLine("SELECT first_name, last_name, group FROM students WHERE student_id = ");
            ID = Console.ReadLine();
            text = ("SELECT first_name, last_name, group FROM students WHERE student_id = " + "'" + ID + "'");
            Console.WriteLine(text);
        }
    }
}
