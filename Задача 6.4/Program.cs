using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int funt_0, funt_1, gramm_0, gramm_1;
            funt_0 = 1;
            funt_1 = 20;
            gramm_0 = 453;
            gramm_1 = 9060;
            Console.WriteLine("фунт      грамм");
            while (funt_1 >= funt_0 && gramm_1 >= gramm_0)
            {
                Console.WriteLine("{0}         {1}", funt_0, gramm_0);
                funt_0++; 
                gramm_0 += 453;
            }
            
                
               
            
            
        }
    }
}
