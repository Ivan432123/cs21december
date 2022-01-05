using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int small = Convert.ToInt32(Console.ReadLine());
            int large = Convert.ToInt32(Console.ReadLine());
            
            int maxSmall = 5;
            int maxLarge = 8;


            if (maxLarge < (large + small) && maxSmall >= small && maxLarge >= large && small > 0 && large > 0)
            {


                int resultSmall = small - (maxLarge - large);
                int resultLarge = large + (maxLarge - large);
                
                Console.WriteLine("Было: в маленькой {0} из 5, в большой {1} из 8", small, large);
                Console.WriteLine("Стало: в маленькой {0} из 5, в большой {1} из 8", resultSmall, resultLarge);


            }

            if (maxLarge >= (large + small) && small > 0 && large > 0)
             {

                 int resultSmall = (small - small);
                 int resultLarge = (small + large);
                 Console.WriteLine("Было: в маленькой {0} из 5, в большой {1} из 8", small, large);
                 Console.WriteLine("Стало: в маленькой {0} из 5, в большой {1} из 8", resultSmall, resultLarge);
             }
            if (maxSmall < small)
             {
                 Console.WriteLine("Фактическое количество жидкости в маленькой емкости должно быть от 0 до " + maxSmall + " литров включительно");
             }
            if (maxLarge < large)
            {
                Console.WriteLine("Фактическое количество жидкости в большой емкости должно быть от 0 до " + maxLarge + " литров включительно");
            }
            if (small < 0)
            {
                Console.WriteLine("Фактическое количество жидкости в маленькой емкости должно быть от 0 до " + maxSmall + " литров включительно");
            }
            if (large < 0)
                Console.WriteLine("Фактическое количество жидкости в большой емкости должно быть от 0 до " + maxLarge + " литров включительно");


        }
    }
}

            



            
