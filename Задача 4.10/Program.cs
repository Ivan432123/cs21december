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
            double buyTax = Double.Parse(Console.ReadLine());
            double sellTax = Double.Parse(Console.ReadLine());
            const double n = 0.18;
            double buyNds = buyTax * n; 
            double sellNds = sellTax * n;
            

            double ruble_buyNds = Math.Truncate(buyNds);                // отображает рубли на вход НДС после округления 
            double cop_buyNds = buyNds - Math.Truncate(buyNds);         // отображает копейки на вход НДС после округления
            double ruble_sellNds = Math.Truncate(sellNds);              // отображает рубли на выход НДС после округления
            double cop_sellNds = sellNds - Math.Truncate(sellNds);      // отображает копейки на выход НДС после округления

            double differenceNds = sellNds - buyNds;                    // разница НДС
            double ruble_differenceNds = Math.Truncate(differenceNds);  // отображает рубли в разнице НДС
            double cop_diff = differenceNds - ruble_differenceNds;      // отображает копейки в разнице НДС

            Console.WriteLine("Раннее округление\nНДС вход {0:F6}, после округления {1} рублей {2} копеек " +
                "\nНДС выход {3:F6}, после округления {4} рублей {5:F2} копеек", buyNds, ruble_buyNds, cop_buyNds, sellNds, ruble_sellNds, cop_sellNds);

            Console.WriteLine("Требуется уплатить {0} рублей {1:F2} копеек", ruble_differenceNds, cop_diff);

            Console.WriteLine("Позднее округление\nНДС вход {0:F6} рублей\nНДС выход {1:F6} рублей\nТребуется уплатить {2:F6}, после округления" + 
                "{3} рублей {4:F2} копеек", buyNds, sellNds, differenceNds, ruble_differenceNds, cop_diff);
            

        }
    }
}
