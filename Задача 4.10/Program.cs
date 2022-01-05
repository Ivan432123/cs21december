using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buyTax = Convert.ToDouble(Console.ReadLine());
            double sellTax = Convert.ToDouble(Console.ReadLine());
            const double n = 0.18;
            double buynds = buyTax * n; 
            double sellnds = sellTax * n;
            
            Console.WriteLine("Раннее округление\nНДС вход {0:F6}, после округления {0:0} рублей  копеек\nНДС выход {1:F6}, после округления {1:0} рублей  копеек",buynds, sellnds);
            Console.WriteLine();
            

        }
    }
}
