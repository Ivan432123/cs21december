using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = b + 1;





            if (a < c)
            {
                while (a < c)
                {


                    Console.WriteLine("{0} {1}", a, b);
                    a++;
                    b--;

                }
            }





            
            
            
              else
                while (a > b)
                {

                    Console.WriteLine("{0} {1}", b, a);
                    a--;
                    b++;
                }
            }
        }
        }
            
        
    

