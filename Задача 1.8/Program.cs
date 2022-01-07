using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1._8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string companyName, productName, productCost, messagePart;
            
            Console.WriteLine("Задача 1910");
            Console.WriteLine("Введите название компании: ");
            companyName = Console.ReadLine();
            Console.WriteLine("Введите наименование товара: ");
            productName = Console.ReadLine();
            Console.WriteLine("Введите цену товар: ");
            productCost = Console.ReadLine();
            messagePart = ("Распродажа в " + companyName + "!" + " Наши " + productName + " по супер цене. Всего " + productCost + " !");
            Console.WriteLine(messagePart);
            Console.WriteLine("Торопитесь, предложение ограничено!");
        }
    }
}
